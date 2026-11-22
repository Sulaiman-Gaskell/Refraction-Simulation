# .NET Version Upgrade

## Preferences
- **Flow Mode**: Automatic
- **Target Framework**: net10.0
- **Project Scope**: Refraction Simulation.csproj

## Source Control
- **Source Branch**: main
- **Working Branch**: upgrade-dotnet-10
- **Pending Changes**: None
- **Commit Strategy**: After Each Task
- **Branch Sync**: Auto (Merge)

## Upgrade Options

### Strategy
- Upgrade Strategy: All-at-Once

### Project Structure
- Project Approach: In-place

### Compatibility
- Unsupported API Handling: Fix Inline

## Strategy
**Selected**: All-at-Once
**Rationale**: Single .NET Framework WinForms project with no project dependencies; all changes can be handled in one atomic upgrade.

### Execution Constraints
- Convert the legacy project to SDK-style before changing the target framework.
- Upgrade the WinForms project to the Windows-specific .NET 10 target in one atomic pass.
- Restore dependencies and resolve all compilation errors, including Windows Forms, System.Drawing, and legacy configuration compatibility issues.
- Validate the full solution build with zero errors and run available tests after the upgrade.
