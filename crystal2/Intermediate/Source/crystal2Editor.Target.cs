using UnrealBuildTool;

public class crystal2EditorTarget : TargetRules
{
	public crystal2EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("crystal2");
	}
}
