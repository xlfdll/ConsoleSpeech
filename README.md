# Console Speech
A console-based speech interpreter in .NET Framework

## System Requirements
* .NET Framework 3.x

[Runtime configuration](https://docs.microsoft.com/en-us/dotnet/framework/migration-guide/how-to-configure-an-app-to-support-net-framework-4-or-4-5) is needed for running on .NET Framework 4.0+.

## Usage
Just run and type what you want computer to speak (Ctrl+C to exit)

OR

Put what you want computer to speak as command-line arguments, with the following forms:

* Normal strings as words
```
ConsoleSpeech.exe I am use Windows
```
* Quoted strings as sentences
```
ConsoleSpeech.exe "I am use Windows" "What about you?"
```

## Development Prerequisites
* Visual Studio 2012+

Before the build, generate-build-number.sh needs to be executed in a Git / Bash shell to generate build information code file (`BuildInfo.cs`).
