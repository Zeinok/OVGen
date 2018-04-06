# Oscilloscope View Generator

A software you can put WAV files and make oscilloscope view thing.

## Installing

Decompress the zip file to any directory and run `OVGen.exe`

### Requirements:

+ Windows 7 or up
+ .NET Framework 4.0 Runtime
+ [FFmpeg](https://ffmpeg.zeranoe.com/builds/) (for video encoding)

## How to use it

Please refer to [wiki](https://github.com/Zeinok/OVGen/wiki).

## Deployment

Build OVGen with Visual Studio 2017.

## License

OVGen is licensed under the MIT License, see LICENSE.md for more information.

## Specs
+ Open 16-bit or 8-bit depth WAV
+ Output as PNG (image each frame) or MP4 (video,requires FFmpeg)
+ If output as video, directly feed raw image into FFmpeg. 
+ In-program amplification
+ External trigger option
+ Per channel horizontal time
+ Set color for each channel
+ Preview mode
+ Toggleable output displaying
+ CRT oscilloscope rendering mode
+ Auto Amplify
