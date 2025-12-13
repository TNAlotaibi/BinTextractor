# BinTextractor

<p align="center">
  <img src="https://raw.githubusercontent.com/TNAlotaibi/BinTextractor/refs/heads/main/BinTextractor_Logo.png" width="250" alt="Project Logo">
</p>
A professional Windows application for extracting readable strings from binary executable files. Built with .NET and Guna2 UI framework.

## Overview

BinTextractor is a GUI-based tool designed to extract ASCII and Unicode strings from executable files (.exe, .dll, .bin, .sys). It provides real-time extraction feedback, filtering capabilities, and multiple export options.

## Features

- **String Extraction**: Extract readable strings from binary files
- **Encoding Support**: ASCII and Unicode string detection
- **Configurable Minimum Length**: Set minimum string length threshold
- **Regex Pattern Filtering**: Filter results using regular expressions
- **Real-time Progress**: Live progress tracking during extraction
- **Search Functionality**: Search and filter extracted results
- **Export Options**: Save results to text files
- **Drag and Drop**: Drag files directly into the application
- **Modern UI**: Dark-themed interface with Guna2 components

## Screenshot

<p align="center">
  <img src="https://raw.githubusercontent.com/TNAlotaibi/BinTextractor/refs/heads/main/Screenshot.png" width="750" alt="Screenshot Of GUI">
   <br>
  <em>The GUI after run the app</em>
</p>
<p align="center">
  <img src="https://raw.githubusercontent.com/TNAlotaibi/BinTextractor/refs/heads/main/Screenshot (2).png" width="750" alt="Screenshot Of GUI">
   <br>
  <em>Result of strings</em>
</p>
<p align="center">
  <img src="https://raw.githubusercontent.com/TNAlotaibi/BinTextractor/refs/heads/main/Screenshot (3).png" width="750" alt="Screenshot Of GUI">
   <br>
  <em>Result of regex search for URLs</em>
</p>

## Requirements

- Windows 10/11
- .NET 8.0 or later
- mstrings.exe or strings.exe (Sysinternals) in application directory

## Installation

1. Clone the repository
2. Open the solution in Visual Studio 2022
3. Restore NuGet packages (Guna.UI2.WinForms)
4. Build the solution
5. Place `mstrings.exe` or `strings.exe` in the output directory

## Dependencies

| Package | Version | Description |
|---------|---------|-------------|
| Guna.UI2.WinForms | Latest | Modern UI components |

## Usage

1. Launch BinTextractor
2. Click **Browse** to select a target executable file (or drag and drop)
3. Configure extraction options:
   - Enable/disable ASCII extraction
   - Enable/disable Unicode extraction
   - Set minimum string length
   - Add regex pattern filter (optional)
4. Click **Extract** to start extraction
5. Use the search box to filter results
6. Click **Save** to export results to a text file


## Configuration Options

| Option | Description | Default |
|--------|-------------|---------|
| ASCII | Extract ASCII strings | Enabled |
| Unicode | Extract Unicode strings | Enabled |
| Minimum Length | Minimum characters for valid string | 4 |
| Search Pattern | Regex filter for extraction | None |
## Building from Source

```bash
# Clone repository
git clone https://github.com/yourusername/BinTextractor.git

# Navigate to project directory
cd BinTextractor

# Restore packages and build
dotnet restore
dotnet build --configuration Release
```

## Technical Details

- **Framework**: .NET 8.0 Windows Forms
- **UI Library**: Guna.UI2.WinForms
- **Architecture**: Single-threaded UI with async extraction
- **String Detection**: Utilizes Sysinternals strings tool

## Known Limitations

- Requires external strings tool (mstrings.exe or strings.exe)
- Windows-only application
- Large files may take significant time to process

## License

Copyright (c) 2025 TNAlotaibi

This software is provided for educational and personal use.

**You ARE allowed to:**
- Use this software for personal and educational purposes
- Modify the code for personal use
- Share the original repository link

**You are NOT allowed to:**
- Claim this source code as your own
- Remove or modify the copyright notice
- Sell this software or any modified version
- Redistribute without proper attribution to the original author

Any unauthorized use, reproduction, or claim of ownership is strictly prohibited.

For any inquiries, contact the author.

## Author

**TNAlotaibi** - [@TNAlotaibi](https://github.com/TNAlotaibi)
