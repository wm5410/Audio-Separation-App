# Play It Again Sam - Music Separation App

## Overview
A Windows Forms music player with source separation using Demucs and NAudio.  
Allows you to import songs, separate them into stems (vocals, drums, bass, other), adjust volumes, visualize waveforms, and play combined or individual stems.

## Features
- Import `.mp3` and `.wav` files from your Music folder or via file dialog  
- Play, pause, and stop audio  
- Separate audio into stems using Demucs  
- Adjust volume of each stem and mix on the fly  
- Visualize waveforms for each stem  
- Combine separated stems into a single playback  

## Prerequisites
- Windows 10/11  
- [Anaconda3](https://www.anaconda.com/products/distribution) (3.x series)  
- Visual Studio 2022 (with C# .NET desktop development workload)

## Setup Instructions

1. **Install Anaconda3**  
   - Download and install Anaconda3 for Windows.  
   - (Optional) Check **Add Anaconda to my PATH** for easier shell access.

2. **Clone the Repository**  
   ```bash
   git clone https://github.com/EspressoIntenso/PlayItAgainSam.git
   cd PlayItAgainSam/COMPX241_musicPlayer
   ```

3. **Environment Configuration**
   Create `environment.yml` in the project root with:
   ```yaml
   name: demucs-env
   channels:
     - defaults
     - conda-forge
   dependencies:
     - python=3.10
     - ffmpeg        # audio I/O support
     - pip
     - pip:
       - demucs
       - lameenc
       - mir_eval
   ```
   Then in **Anaconda Prompt**:
   ```bash
   conda env create -f environment.yml
   conda activate demucs-env
   ```

4. **Verify Tools**
   ```bash
   demucs --help
   ffmpeg -version
   ```

5. **Configure Visual Studio**
   - Open solution in Visual Studio 2022.  
   - Ensure `<LangVersion>8.0</LangVersion>` is added to the main `<PropertyGroup>` in `.csproj`:
     ```xml
     <LangVersion>8.0</LangVersion>
     ```
   - Rebuild the project.

## Usage
1. Launch the app from Visual Studio or from `bin\Debug` folder.  
2. Use **File > Open** to select an audio file.  
3. Click **Separate Audio** to run Demucs (background).  
4. Once separation completes, waveforms appear in the UI.  
5. Check/uncheck stems and adjust track bars to mix stems.  
6. Play or pause combined output.

## Implementation Details
- **Process Launch**: Uses `ProcessStartInfo` to call `demucs.exe` directly from the conda env without blocking UI:
  ```csharp
  var proc = new Process();
  proc.StartInfo.FileName = @"C:\Users\William\anaconda3\envs\demucs-env\Scripts\demucs.exe";
  proc.StartInfo.Arguments = $""{audioPath}"";
  proc.StartInfo.RedirectStandardOutput = true;
  proc.StartInfo.RedirectStandardError = true;
  proc.StartInfo.UseShellExecute = false;
  proc.StartInfo.CreateNoWindow = true;
  await Task.Run(() => {
      proc.Start();
      proc.StandardOutput.ReadToEnd();
      proc.StandardError.ReadToEnd();
      proc.WaitForExit();
  });
  ```
- **NAudio**: Handles playback, mixing, and waveform drawing.
- **Waveform Visualization**: Reads samples via `WaveFileReader`, renders with GDI+.

## Troubleshooting
- **`conda` not recognized**:  
  - Use **Anaconda Prompt** or run `conda init powershell` in Anaconda Prompt, then restart PowerShell.
- **UI freeze**:  
  - Ensure separation runs inside `Task.Run` with `async/await`.
- **Feature `using declarations` error**:  
  - Confirm `<LangVersion>8.0</LangVersion>` in `.csproj` and rebuild.

## References
- Demucs: https://github.com/facebookresearch/demucs  
- NAudio: https://github.com/naudio/NAudio

