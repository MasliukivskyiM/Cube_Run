using UnrealBuildTool;

public class GameCube1ServerTarget : TargetRules
{
	public GameCube1ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("GameCube1");
	}
}
