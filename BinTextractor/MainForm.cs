using Guna.UI2;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace BinTextractor
{
    public partial class MainForm : Form
    {
        private bool _isMouseDown;
        private Point _lastLocation;
        private Process? currentProcess;
        private bool isExtracting = false;
        private List<string> allResults = new List<string>();
        private List<string> filteredResults = new List<string>();
        private int currentStringCount = 0;

        public MainForm()
        {
            InitializeComponent();
            textBoxOutputPath.Text = Path.Combine(Application.StartupPath, "extracted_strings.txt");
            timerProgress.Stop();
            this.Resize += MainForm_Resize;
            maximuzeToolTip.InitialDelay = 500;
            maximuzeToolTip.SetToolTip(maxBtn, "Maximize is disabled");
            this.MaximizeBox = false;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
            this.Refresh();
        }

        private void buttonBrowseTarget_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable Files (*.exe;*.dll;*.bin;*.sys)|*.exe;*.dll;*.bin;*.sys|All Files (*.*)|*.*";
                openFileDialog.Title = "Select Target File for String Extraction";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxTargetPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void buttonBrowseOutput_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Select Output File";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.FileName = "extracted_strings.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxOutputPath.Text = saveFileDialog.FileName;
                }
            }
        }

        private async void buttonExtract_Click(object sender, EventArgs e)
        {
            if (isExtracting)
                return;

            if (string.IsNullOrWhiteSpace(textBoxTargetPath.Text))
            {
                MessageBox.Show("Please select a target file to extract strings from.", "Input Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(textBoxTargetPath.Text))
            {
                MessageBox.Show("The selected target file does not exist.", "File Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxOutputPath.Text))
            {
                MessageBox.Show("Please specify an output file path.", "Input Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await StartExtractionAsync();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopExtraction();
        }

        private void buttonClearResults_Click(object sender, EventArgs e)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action<object, EventArgs>(buttonClearResults_Click), sender, e);
                    return;
                }

                richTextBoxResults.Clear();
                allResults.Clear();
                filteredResults.Clear();
                textBoxSearch.Clear();
                labelStats.Text = "Ready for extraction...";
                toolStripStatusLabel.Text = "Ready";
                progressBarExtraction.Value = 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error clearing results: {ex.Message}");
            }
        }

        private void buttonCopyResults_Click(object sender, EventArgs e)
        {
            if (richTextBoxResults.Text.Length > 0)
            {
                Clipboard.SetText(richTextBoxResults.Text);
                MessageBox.Show("Results copied to clipboard.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSaveResults_Click(object sender, EventArgs e)
        {
            if (richTextBoxResults.Text.Length == 0)
            {
                MessageBox.Show("No results to save.", "Empty Results",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                File.WriteAllText(textBoxOutputPath.Text, richTextBoxResults.Text);
                MessageBox.Show($"Results saved to: {textBoxOutputPath.Text}", "Save Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Save Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            if (isExtracting)
            {
                if (progressBarExtraction.Value >= 100)
                {
                    progressBarExtraction.Value = 0;
                }
                else
                {
                    progressBarExtraction.Value += 10;
                }
            }
            else
            {
                timerProgress.Stop();
            }
        }

        private void textBoxTargetPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBoxTargetPath_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                textBoxTargetPath.BorderColor = Color.FromArgb(59, 130, 246);
            }
        }

        private void textBoxTargetPath_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data == null) return;

                string[]? files = (string[]?)e.Data.GetData(DataFormats.FileDrop);

                if (files != null && files.Length > 0)
                {
                    string droppedFile = files[0];

                    if (File.Exists(droppedFile))
                    {
                        string extension = Path.GetExtension(droppedFile).ToLowerInvariant();
                        string[] validExtensions = { ".exe", ".dll", ".bin", ".sys", ".dat", ".img", ".iso" };

                        if (validExtensions.Contains(extension) || IsValidBinaryFile(droppedFile))
                        {
                            textBoxTargetPath.Text = droppedFile;

                            if (string.IsNullOrWhiteSpace(textBoxOutputPath.Text) ||
                                textBoxOutputPath.Text.Contains("extracted_strings.txt"))
                            {
                                string outputPath = Path.Combine(
                                    Path.GetDirectoryName(droppedFile) ?? Application.StartupPath,
                                    $"{Path.GetFileNameWithoutExtension(droppedFile)}_extracted_strings.txt");
                                textBoxOutputPath.Text = outputPath;
                            }

                            toolStripStatusLabel.Text = $"File loaded: {Path.GetFileName(droppedFile)}";
                        }
                        else
                        {
                            MessageBox.Show("Please drop a valid binary file (e.g., .exe, .dll, .bin, .sys).",
                                "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            toolStripStatusLabel.Text = "Invalid file type dropped";
                        }
                    }
                    else
                    {
                        MessageBox.Show("The dropped item is not a valid file.",
                            "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing dropped file: {ex.Message}",
                    "Drag & Drop Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "Error processing dropped file";
            }
        }

        private bool IsValidBinaryFile(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[Math.Min(1024, fs.Length)];
                    int bytesRead = fs.Read(buffer, 0, buffer.Length);

                    int nonPrintableCount = 0;
                    for (int i = 0; i < bytesRead; i++)
                    {
                        byte b = buffer[i];
                        if (b < 32 || b > 126)
                        {
                            nonPrintableCount++;
                        }
                    }

                    return (nonPrintableCount / (double)bytesRead) > 0.2;
                }
            }
            catch
            {
                return false;
            }
        }

        private void ShowAboutDialog()
        {
            using (Form aboutForm = new Form())
            {
                aboutForm.Size = new Size(400, 300);
                aboutForm.Text = "About BinTextractor Pro";
                aboutForm.StartPosition = FormStartPosition.CenterParent;
                aboutForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                aboutForm.MaximizeBox = false;
                aboutForm.MinimizeBox = false;
                aboutForm.ShowInTaskbar = false;

                var labelTitle = new Label
                {
                    Text = "BinTextractor Pro",
                    Font = new Font("Segoe UI", 16, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(20, 20)
                };

                var labelVersion = new Label
                {
                    Text = "Version 1.0",
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true,
                    Location = new Point(20, 50)
                };

                var labelDescription = new Label
                {
                    Text = "A professional tool for extracting strings from executable files.\n\n" +
                           "Features:\n" +
                           "• Advanced string filtering\n" +
                           "• Real-time progress tracking\n" +
                           "• Multiple output formats\n" +
                           "• Search and export capabilities\n\n" +
                           "Built with .NET By TNAlotaibi.",
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true,
                    Location = new Point(20, 80),
                    MaximumSize = new Size(350, 150)
                };

                var buttonOK = new Button
                {
                    Text = "OK",
                    Size = new Size(75, 25),
                    Location = new Point(150, 220),
                    DialogResult = DialogResult.OK
                };
                buttonOK.Click += (s, e) => aboutForm.Close();

                aboutForm.Controls.AddRange(new Control[] { labelTitle, labelVersion, labelDescription, buttonOK });
                aboutForm.ShowDialog();
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            ShowAboutDialog();
        }

        private async Task StartExtractionAsync()
        {
            isExtracting = true;
            currentStringCount = 0;

            buttonExtract.Enabled = false;
            buttonStop.Enabled = true;
            buttonStop.ShadowDecoration.Enabled = buttonStop.Enabled;
            timerProgress.Start();
            progressBarExtraction.Value = 0;
            richTextBoxResults.Clear();
            allResults.Clear();
            filteredResults.Clear();

            try
            {
                string? stringsToolPath = FindStringsTool();

                if (string.IsNullOrEmpty(stringsToolPath))
                {
                    MessageBox.Show("Could not find 'strings' tool (mstrings.exe). Please ensure it's available in the application directory or system PATH.",
                        "Tool Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string arguments = BuildStringsArguments();
                await ExtractStringsAsync(stringsToolPath, arguments);
            }
            catch (Exception ex)
            {
                if (isExtracting)
                {
                    MessageBox.Show($"Extraction failed: {ex.Message}", "Extraction Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                isExtracting = false;
                buttonExtract.Enabled = true;
                buttonStop.Enabled = false;
                buttonStop.ShadowDecoration.Enabled = buttonStop.Enabled;
                timerProgress.Stop();
                progressBarExtraction.Value = isExtracting ? 0 : 100;
                DisplayAllResults();
            }
        }

        private string? FindStringsTool()
        {
            List<string> possiblePaths = new List<string>
            {
                Path.Combine(Application.StartupPath, "mstrings.exe"),
                Path.Combine(Application.StartupPath, "strings.exe"),
                "mstrings.exe",
                "strings.exe",
                @"C:\Windows\System32\strings.exe",
                @"C:\Windows\SysWOW64\strings.exe"
            };

            foreach (string path in possiblePaths)
            {
                if (File.Exists(path))
                {
                    return path;
                }
            }

            return null;
        }

        private string BuildStringsArguments()
        {
            List<string> arguments = new List<string>();

            // Check ASCII checkbox
            if (checkBoxAscii.Checked)
                arguments.Add("-a");

            // Check Unicode checkbox
            if (checkBoxUnicode.Checked)
                arguments.Add("-u");

            int minLength = (int)numericUpDownMinLength.Value;
            arguments.Add($"-n {minLength}");

            arguments.Add($"\"{textBoxTargetPath.Text}\"");

            return string.Join(" ", arguments);
        }

        private async Task ExtractStringsAsync(string toolPath, string arguments)
        {
            Process? extractionProcess = null;
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = toolPath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    StandardOutputEncoding = System.Text.Encoding.UTF8
                };

                extractionProcess = Process.Start(psi);

                if (extractionProcess == null)
                {
                    throw new Exception("Failed to start extraction process");
                }

                currentProcess = extractionProcess;

                using (StreamReader reader = extractionProcess.StandardOutput)
                {
                    string? line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        if (!isExtracting || currentProcess != extractionProcess)
                        {
                            break;
                        }

                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            if (ShouldIncludeLine(line))
                            {
                                allResults.Add(line);
                                currentStringCount++;

                                if (currentStringCount % 100 == 0 || currentStringCount <= 5)
                                {
                                    UpdateResultsInRealTime(line, currentStringCount);
                                    UpdateProgressBar(currentStringCount);
                                }
                            }
                        }
                    }
                }

                if (isExtracting && currentProcess == extractionProcess)
                {
                    await extractionProcess.WaitForExitAsync();

                    if (extractionProcess.ExitCode != 0)
                    {
                        string errorOutput = await extractionProcess.StandardError.ReadToEndAsync();
                        if (!string.IsNullOrEmpty(errorOutput))
                        {
                            throw new Exception($"Tool error: {errorOutput}");
                        }
                    }

                    FinalizeResults(currentStringCount);

                    if (!string.IsNullOrWhiteSpace(textBoxOutputPath.Text))
                    {
                        File.WriteAllLines(textBoxOutputPath.Text, allResults);
                    }
                }
            }
            catch (Exception ex)
            {
                if (isExtracting)
                {
                    throw new Exception($"Failed to extract strings: {ex.Message}", ex);
                }
            }
            finally
            {
                try
                {
                    currentProcess = null;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error clearing process reference: {ex.Message}");
                }

                extractionProcess?.Dispose();
            }
        }

        private void UpdateResultsInRealTime(string newString, int currentCount)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action<string, int>(UpdateResultsInRealTime), newString, currentCount);
                    return;
                }

                richTextBoxResults.AppendText(newString + Environment.NewLine);

                if (currentCount % 50 == 0)
                {
                    richTextBoxResults.SelectionStart = richTextBoxResults.Text.Length;
                    richTextBoxResults.ScrollToCaret();
                }

                labelStats.Text = $"{currentCount} strings extracted...";
                toolStripStatusLabel.Text = $"Extracting: {currentCount} strings found";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error updating results in real-time: {ex.Message}");
            }
        }

        private void UpdateProgressBar(int stringCount)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action<int>(UpdateProgressBar), stringCount);
                    return;
                }

                int estimatedProgress = Math.Min((stringCount * 100) / 1000, 95);
                progressBarExtraction.Value = estimatedProgress;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error updating progress bar: {ex.Message}");
            }
        }

        private void FinalizeResults(int finalCount)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action<int>(FinalizeResults), finalCount);
                    return;
                }

                progressBarExtraction.Value = 100;
                labelStats.Text = $"Extraction complete: {finalCount} strings extracted";
                toolStripStatusLabel.Text = $"Completed: {finalCount} strings";

                ProcessAndDisplayResults();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error finalizing results: {ex.Message}");
            }
        }

        private bool ShouldIncludeLine(string line)
        {
            if (line.Contains("Sysinternals") || line.Contains("Mark Russinovich"))
                return false;

            if (line.StartsWith("Strings v", StringComparison.OrdinalIgnoreCase))
                return false;

            if (!string.IsNullOrWhiteSpace(textBoxSearchPattern.Text))
            {
                try
                {
                    Regex regex = new Regex(textBoxSearchPattern.Text, RegexOptions.IgnoreCase);
                    return regex.IsMatch(line);
                }
                catch
                {
                    return true;
                }
            }

            return true;
        }

        private void ProcessAndDisplayResults()
        {
            string searchText = textBoxSearch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                return;
            }
            else
            {
                ApplySearchFilter();
            }
        }

        private void ApplySearchFilter()
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(ApplySearchFilter));
                    return;
                }

                string searchText = textBoxSearch.Text.ToLower();

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    DisplayAllResults();
                }
                else
                {
                    DisplayFilteredResults(searchText);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error applying search filter: {ex.Message}");
            }
        }

        private void DisplayAllResults()
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(DisplayAllResults));
                    return;
                }

                richTextBoxResults.Clear();
                foreach (string result in allResults)
                {
                    richTextBoxResults.AppendText(result + Environment.NewLine);
                }

                labelStats.Text = $"Showing all {allResults.Count} strings";
                richTextBoxResults.SelectionStart = 0;
                richTextBoxResults.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error displaying all results: {ex.Message}");
            }
        }

        private void DisplayFilteredResults(string searchText)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action<string>(DisplayFilteredResults), searchText);
                    return;
                }

                richTextBoxResults.Clear();
                filteredResults = allResults
                    .Where(line => line.ToLower().Contains(searchText))
                    .ToList();

                foreach (string result in filteredResults)
                {
                    richTextBoxResults.AppendText(result + Environment.NewLine);
                }

                labelStats.Text = $"Filtered: {filteredResults.Count} of {allResults.Count} strings";
                richTextBoxResults.SelectionStart = 0;
                richTextBoxResults.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error displaying filtered results: {ex.Message}");
            }
        }

        private void StopExtraction()
        {
            isExtracting = false;

            try
            {
                currentProcess = null;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in StopExtraction: {ex.Message}");
            }
            finally
            {
                timerProgress.Stop();
                buttonExtract.Enabled = true;
                buttonStop.Enabled = false;
                buttonStop.ShadowDecoration.Enabled = buttonStop.Enabled;
                progressBarExtraction.Value = 0;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                if (isExtracting || currentProcess != null)
                {
                    isExtracting = false;
                    StopExtraction();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error during form cleanup: {ex.Message}");
            }

            base.OnFormClosing(e);
        }

        private void labelStats_Click(object sender, EventArgs e)
        {
        }

        private void ApplyDarkTheme()
        {
            this.BackColor = Color.FromArgb(30, 34, 42);
            panelHeader.FillColor = Color.FromArgb(18, 19, 23);
            panelLeft.FillColor = Color.FromArgb(35, 39, 46);
            panelRight.FillColor = Color.FromArgb(25, 27, 32);
            panelBottom.FillColor = Color.FromArgb(18, 19, 23);
            statusStripMain.BackColor = Color.FromArgb(30, 34, 42);

            labelTitle.ForeColor = Color.White;
            labelTargetFile.ForeColor = Color.White;
            labelOutputFile.ForeColor = Color.White;
            labelSearchPattern.ForeColor = Color.White;
            labelMinLength.ForeColor = Color.White;
            labelSearchResults.ForeColor = Color.White;
            labelStats.ForeColor = Color.FromArgb(200, 200, 200);

            groupBoxFilters.ForeColor = Color.White;
            groupBoxResults.ForeColor = Color.White;

            textBoxTargetPath.ForeColor = Color.White;
            textBoxTargetPath.PlaceholderForeColor = Color.FromArgb(150, 150, 150);
            textBoxTargetPath.FillColor = Color.FromArgb(40, 44, 52);
            textBoxOutputPath.ForeColor = Color.White;
            textBoxOutputPath.PlaceholderForeColor = Color.FromArgb(150, 150, 150);
            textBoxOutputPath.FillColor = Color.FromArgb(40, 44, 52);
            textBoxSearchPattern.ForeColor = Color.White;
            textBoxSearchPattern.PlaceholderForeColor = Color.FromArgb(150, 150, 150);
            textBoxSearchPattern.FillColor = Color.FromArgb(40, 44, 52);
            textBoxSearch.ForeColor = Color.White;
            textBoxSearch.PlaceholderForeColor = Color.FromArgb(150, 150, 150);
            textBoxSearch.FillColor = Color.FromArgb(40, 44, 52);

            richTextBoxResults.BackColor = Color.FromArgb(40, 44, 52);
            richTextBoxResults.ForeColor = Color.White;

            numericUpDownMinLength.BackColor = Color.FromArgb(40, 44, 52);
            numericUpDownMinLength.ForeColor = Color.White;

            checkBoxUnicode.ForeColor = Color.White;
            checkBoxAscii.ForeColor = Color.White;

            progressBarExtraction.FillColor = Color.FromArgb(60, 65, 75);
            toolStripStatusLabel.ForeColor = Color.White;
            buttonAbout.BackColor = Color.Transparent;
            buttonTheme.BackColor = Color.Transparent;
        }

        private void ApplyLightTheme()
        {
            this.BackColor = Color.FromArgb(248, 250, 252);
            panelHeader.FillColor = Color.FromArgb(45, 55, 72);
            panelLeft.FillColor = Color.FromArgb(249, 250, 251);
            panelRight.FillColor = Color.White;
            panelBottom.FillColor = Color.FromArgb(45, 55, 72);
            statusStripMain.BackColor = Color.FromArgb(240, 240, 240);

            labelTitle.ForeColor = Color.White;
            labelTargetFile.ForeColor = Color.FromArgb(31, 41, 55);
            labelOutputFile.ForeColor = Color.FromArgb(31, 41, 55);
            labelSearchPattern.ForeColor = Color.FromArgb(31, 41, 55);
            labelMinLength.ForeColor = Color.FromArgb(31, 41, 55);
            labelSearchResults.ForeColor = Color.FromArgb(31, 41, 55);
            labelStats.ForeColor = Color.FromArgb(107, 114, 128);

            groupBoxFilters.ForeColor = Color.FromArgb(31, 41, 55);
            groupBoxResults.ForeColor = Color.FromArgb(31, 41, 55);

            textBoxTargetPath.ForeColor = Color.FromArgb(31, 41, 55);
            textBoxTargetPath.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxTargetPath.FillColor = Color.White;
            textBoxOutputPath.ForeColor = Color.FromArgb(31, 41, 55);
            textBoxOutputPath.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxOutputPath.FillColor = Color.White;
            textBoxSearchPattern.ForeColor = Color.FromArgb(31, 41, 55);
            textBoxSearchPattern.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxSearchPattern.FillColor = Color.White;
            textBoxSearch.ForeColor = Color.FromArgb(31, 41, 55);
            textBoxSearch.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxSearch.FillColor = Color.White;

            richTextBoxResults.BackColor = Color.White;
            richTextBoxResults.ForeColor = Color.Black;

            numericUpDownMinLength.BackColor = Color.White;
            numericUpDownMinLength.ForeColor = Color.Black;

            checkBoxUnicode.ForeColor = Color.FromArgb(31, 41, 55);
            checkBoxAscii.ForeColor = Color.FromArgb(31, 41, 55);

            progressBarExtraction.FillColor = Color.FromArgb(230, 230, 230);
            toolStripStatusLabel.ForeColor = Color.Black;
        }

        private void buttonTheme_Click(object sender, EventArgs e)
        {
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            maximuzeToolTip.Show("Maximize is disabled", maxBtn);
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (!_isMouseDown)
                return;
            Location = new Point(
                Location.X - _lastLocation.X + e.X, Location.Y - _lastLocation.Y + e.Y);

            Update();
        }



        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
            Opacity = 1.0;
        }
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            _isMouseDown = true;
            _lastLocation = e.Location;
            Opacity = 0.98;
        }
    }
}
