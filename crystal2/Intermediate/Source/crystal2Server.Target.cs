using UnrealBuildTool;

public class crystal2ServerTarget : TargetRules
{
	public crystal2ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("crystal2");
	}
}
