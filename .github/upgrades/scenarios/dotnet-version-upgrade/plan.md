# .NET Version Upgrade Plan

## Overview

**Target**: Upgrade `Refraction Simulation.csproj` from .NET Framework 4.7.2 to .NET 10 for Windows.
**Scope**: One classic WinForms project, 14 code files with API compatibility findings concentrated in Windows Forms, System.Drawing, and legacy configuration usage.

## Upgrade Options

| Option | Selected | Why |
|--------|----------|-----|
| Upgrade Strategy | All-at-Once | Single .NET Framework project with no project dependencies; all changes can be handled in one atomic upgrade. |
| Project Approach | In-place | The project is a classic WinForms application, so the existing project will be converted and retargeted directly. |
| Unsupported API Handling | Fix Inline | Windows Forms, System.Drawing, and legacy configuration API changes must be resolved for the project to compile on .NET 10. |

## Tasks

### 01-prerequisites: Verify .NET 10 upgrade prerequisites

Verify that the .NET 10 SDK and Windows desktop workload are available, and confirm that any `global.json` SDK selection is compatible with the target. Review the current solution/project configuration before structural changes begin.

**Done when**: Required .NET 10 tooling is available, SDK selection is compatible, and the solution/project is ready for conversion.

### 02-sdk-conversion: Convert the WinForms project to SDK-style

Convert `Refraction Simulation.csproj` from the legacy project format to SDK-style while retaining its current .NET Framework 4.7.2 target. Preserve WinForms source files, resources, application settings, assembly metadata, icons, and build behavior so the structural conversion is isolated from the framework API migration.

**Done when**: The converted project is SDK-style, restores successfully, and builds on its current target without introducing warnings or losing project assets.

### 03-net10-winforms-upgrade: Upgrade WinForms code to .NET 10 for Windows

Retarget the SDK-style project to `net10.0-windows` with Windows Forms enabled, then resolve the compatibility findings across the 14 affected code files. Address the reported Windows Forms and System.Drawing API changes, legacy configuration usage, and any resulting compile errors inline; preserve the simulation behavior and desktop application entry point.

**Done when**: The project targets `net10.0-windows`, restores successfully, and all source/API compatibility issues are resolved with a warning-free build.

### 04-final-validation: Validate the upgraded solution

Build the complete solution and run all available tests or executable validation supported by the repository. Confirm that the WinForms application output, resources, configuration, and generated binaries are present and document any runtime checks that require manual confirmation.

**Done when**: The solution builds with zero errors and zero warnings, all available tests pass, and remaining manual validation items are documented.
