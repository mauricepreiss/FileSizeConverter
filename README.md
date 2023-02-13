
# FileSizeConverter
## Description
A small short API to convert file sizes from e.g. a disk, directory, file to any size.

Example:
- Gigabyte to Megabyte
- Terrabyte to Gigabyte
- ...
etc.

Just add it to your project via "Right Click > References > Add Reference", then select the DLL and happy converting. ;)

How to add a reference in Visual Studio: https://learn.microsoft.com/en-us/visualstudio/ide/managing-references-in-a-project?view=vs-2022



## Usage

Import on top of your file

```csharp
  using FileSizeConverter;
```

Use like this:

```csharp
  string driveinfo = "Windows";
  DriveInfo drive = new DriveInfo(driveinfo);
  long size = drive.TotalSize;
  string GB = size.ToSize(SizeUnits.GB, DisplayUnitState.Shown)
  // Example Output: 2,55GB
```

## Enums
**Size Units** (The value you want to convert the size in):
```csharp
 public enum SizeUnits
 {
    Byte, KB, MB, GB, TB, PB, EB, ZB, YB
 }
```

**Display Unit State** (You want to have only the value or with it's unit state after it):
```csharp
 public enum DisplayUnitState
 {
    Shown,
    Hidden
 }
```
Example:

**Hidden**: 2,54,
**Shown**: 2,54GB

## License
- no copyright
- free for commertical usage

## Author

[@mauricepreiss](https://www.github.com/mauricepreiss)
