# 02-sdk-conversion: Convert the WinForms project to SDK-style

Convert `Refraction Simulation.csproj` from the legacy project format to SDK-style while retaining its current .NET Framework 4.7.2 target. Preserve WinForms source files, resources, application settings, assembly metadata, icons, and build behavior so the structural conversion is isolated from the framework API migration.

## Research Findings

- **Project scope**: `Refraction Simulation.csproj` is the only project in the solution and has no project dependencies or package references.
- **Current format**: Legacy `ToolsVersion="15.0"` project with explicit `Microsoft.CSharp.targets` import, explicit framework references, and explicit Compile/EmbeddedResource/None/Content items.
- **Current target**: .NET Framework 4.7.2. The conversion must not change this target.
- **Assets to preserve**: five WinForms form/resource pairs, `Properties\Resources.resx` and generated designer, settings files, `App.config`, application icons, and six image/icon assets under `Resources\Icons`.
- **Assessment findings**: SDK-style conversion is mandatory (`Project.0001`). The project has 4,514 total assessment issues, including 3,952 mandatory binary API findings, 560 potential source API findings, 551 System.Drawing findings, 3,952 WinForms findings, and 9 legacy configuration findings; these belong to the later TFM/API task, not this structural conversion.
- **Validation**: The repository has no `packages.config`; the existing legacy solution builds cleanly with Visual Studio MSBuild. Because the project contains designer-generated WinForms `.resx` resources, use Visual Studio MSBuild for post-conversion validation.

**Done when**: The converted project is SDK-style, restores successfully, and builds on its current target without introducing warnings or losing project assets.
