using UnrealBuildTool;

public class GameCube1ClientTarget : TargetRules
{
	public GameCube1ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("GameCube1");
	}
}
