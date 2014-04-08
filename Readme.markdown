This is a template repository of a C# .NET solution and project of a [libVPNET](https://github.com/RoyCurtis/libVPNET) bot. You can fork or pull this repository to get started with programming bots for [Virtual Paradise](http://virtualparadise.org). This repository will be divided into branches for different types of starting bases.

## Getting started
Assuming you have pulled (after forking, if desired) this repository into a local folder:

1. Open `libVPBot.sln`
3. Rename the file `user.example.config` to `user.config`, then [open the file](http://i.imgur.com/njEKzdw.png)
4. Replace `myusername` and `mypassword` with your Virtual Paradise username and password, respectively
5. Press F5 and enjoy!

## Defaults
By default, the template is configured with:

* A Visual Studio 2013 solution file
* Output directory for both configurations (Debug & Release) set to the top-level "Build" directory
* NuGet package restore on build
* .gitignore that ignores any C#/CLI built files and package caches