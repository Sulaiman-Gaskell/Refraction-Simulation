# 03-net10-winforms-upgrade: Upgrade WinForms code to .NET 10 for Windows

Retarget the SDK-style project to `net10.0-windows` with Windows Forms enabled, then resolve the compatibility findings across the 14 affected code files. Address the reported Windows Forms and System.Drawing API changes, legacy configuration usage, and any resulting compile errors inline; preserve the simulation behavior and desktop application entry point.

**Done when**: The project targets `net10.0-windows`, restores successfully, and all source/API compatibility issues are resolved with a warning-free build.
