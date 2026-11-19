# 03-net10-winforms-upgrade: Upgrade WinForms code to .NET 10 for Windows

Retarget the SDK-style project to `net10.0-windows` with Windows Forms enabled, then resolve the compatibility findings across the 14 affected code files. Address the reported Windows Forms and System.Drawing API changes, legacy configuration usage, and any resulting compile errors inline; preserve the simulation behavior and desktop application entry point.

## Research Findings

- **Project scope**: `Refraction Simulation.csproj` is the only project and has no project-to-project or NuGet dependencies.
- **Current project state**: SDK-style conversion is complete, but the project still targets `net472`; the target must be replaced with `net10.0-windows` rather than multi-targeted.
- **WinForms configuration**: `<UseWindowsForms>true</UseWindowsForms>` is already present. The project should retain the Windows desktop SDK behavior and use Visual Studio MSBuild for resource-heavy WinForms validation.
- **Affected source areas**: five forms and their designer files use `System.Windows.Forms` and `System.Drawing`; `Program.cs` uses the classic WinForms startup sequence; `Properties\Resources.Designer.cs` exposes bitmap/icon resources; `Properties\Settings.Designer.cs` derives from `System.Configuration.ApplicationSettingsBase`.
- **Assessment findings**: 3,952 mandatory binary API findings, 560 potential source API findings, 551 System.Drawing findings, 3,952 WinForms findings, and 9 legacy configuration findings. These are primarily framework surface references that should be supplied by the Windows desktop target; the settings API may require the supported `System.Configuration.ConfigurationManager` compatibility package after the first restore/build.
- **Project hygiene**: the conversion tool added an explicit workflow progress-document item to the project after the previous task; it must be removed so `.github` artifacts are not application inputs.
- **Testing**: no test project was discovered; validation will rely on warning-free restore/build and output inspection.

**Done when**: The project targets `net10.0-windows`, restores successfully, and all source/API compatibility issues are resolved with a warning-free build.
