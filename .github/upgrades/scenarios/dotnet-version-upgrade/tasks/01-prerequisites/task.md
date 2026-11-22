# 01-prerequisites: Verify .NET 10 upgrade prerequisites

Verify that the .NET 10 SDK and Windows desktop workload are available, and confirm that any `global.json` SDK selection is compatible with the target. Review the current solution/project configuration before structural changes begin.

## Research Findings

- **Project**: `Refraction Simulation.csproj` is the only project in the solution and is a classic WinForms project targeting .NET Framework 4.7.2.
- **Project format**: Legacy MSBuild format (`ToolsVersion="15.0"`) with explicit framework assembly references and designer/resource item metadata; it must be converted to SDK-style before retargeting.
- **Project assets**: 23 project files include WinForms source/designer files, three form `.resx` files, application resources/settings, an application icon, and `App.config`.
- **SDK availability**: .NET SDK 10.0.403 is installed; .NET SDK 11.0.100 is also installed. No `global.json` exists in the repository, so SDK resolution is compatible with the selected .NET 10 target.
- **Build implication**: Because this is a legacy WinForms project with designer-generated resources, Visual Studio MSBuild is the appropriate validation tool before and during conversion.

**Done when**: Required .NET 10 tooling is available, SDK selection is compatible, and the solution/project is ready for conversion.
