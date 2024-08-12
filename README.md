# ffmpegUI v 1.0.0

ffmpegUI is a Windows Forms application developed using .NET 6.0. It provides an intuitive graphical user interface (GUI) for compressing and trimming videos. The application uses a bundled ffmpeg executable to perform video processing, eliminating the need for external dependencies.

## Features

- **Video Compression**: Compress videos into smaller files with customizable settings for resolution, codecs, and codec specific presets.
- **Video Trimming**: Easily trim videos by specifying start and duration times, accessible through a dedicated trimming interface.
- **Integrated ffmpeg Execution**: Includes a local copy of ffmpeg, ensuring all functionalities are self-contained and operate without requiring external downloads.
- **User-Friendly Interface**: Features distinct pages for compression and trimming functionalities, making it easy for users to navigate and use the specific tools they need.

## Installation

1. Download or clone the repository to your local machine.
2. Open the solution in Visual Studio 2022 or newer.
3. Build the solution to resolve dependencies.
4. Run the application from Visual Studio or directly execute the program from the build output directory.

## Usage

### Video Compression
1. **Launch ffmpegUI**: Start the application via the executable.
2. **Open on Compression Page**: The application opens by default on the compression page.
3. **Select a Video File**: Use the 'Browse' button to choose the video file you want to compress.
4. **Configure Compression Settings**: Adjust settings such as resolution, codec, and codec specific presets.
5. **Process Video**: Click 'Compress' to start the compression process.

### Video Trimming
1. **Navigate to Trimming**: Click the 'Trim' button on the left to switch to the trimming functionality.
2. **Select a Video File**: Use the 'Browse' button to choose the video file you want to trim.
3. **Select an Output Folder**: Use the 'Browse' button to choose destination folder for the new video file.
4. **Set Trimming Options**: Enter the start and end times for the video segments you wish to trim.
5. **Process Video**: Click 'GO' to start the trimming process.

## Configuration

ffmpegUI includes a local ffmpeg executable within the project directory, so no external configuration for ffmpeg is needed.

## License

ffmpegUI is released under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

## Third-Party Licenses

### FFmpeg Licensing

ffmpegUI utilizes FFmpeg, a powerful multimedia framework that decodes, encodes, transcodes, muxes, demuxes, streams, filters, and plays virtually anything that humans and machines have created. FFmpeg is licensed under the GNU Lesser General Public License (LGPL) version 2.1.

It is important for users of ffmpegUI to understand that although ffmpegUI itself is distributed under the MIT License, the use of FFmpeg as part of ffmpegUI is governed by the LGPLv2.1. This may affect how you can use, modify, or distribute ffmpegUI, especially if modifications are made to FFmpeg itself or if FFmpeg is dynamically linked.

For full details of the LGPLv2.1 license, please refer to the official license documentation:
[GNU Lesser General Public License v2.1](https://www.gnu.org/licenses/old-licenses/lgpl-2.1.html).

## Acknowledgments

- Special thanks to the ffmpeg project for providing the powerful ffmpeg tool, which is integral to the functionality of ffmpegUI. The ffmpeg project's dedication to producing a high-quality, open-source multimedia processing tool continues to empower developers globally.