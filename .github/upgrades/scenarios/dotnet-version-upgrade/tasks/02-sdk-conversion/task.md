# 02-sdk-conversion: Convert the WinForms project to SDK-style

Convert `Refraction Simulation.csproj` from the legacy project format to SDK-style while retaining its current .NET Framework 4.7.2 target. Preserve WinForms source files, resources, application settings, assembly metadata, icons, and build behavior so the structural conversion is isolated from the framework API migration.

**Done when**: The converted project is SDK-style, restores successfully, and builds on its current target without introducing warnings or losing project assets.
