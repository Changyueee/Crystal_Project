using UnrealBuildTool;

public class crystal2ClientTarget : TargetRules
{
	public crystal2ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("crystal2");
	}
}
