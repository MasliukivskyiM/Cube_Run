using UnrealBuildTool;

public class GameCube1Target : TargetRules
{
	public GameCube1Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("GameCube1");
	}
}
