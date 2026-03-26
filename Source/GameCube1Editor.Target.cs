using UnrealBuildTool;

public class GameCube1EditorTarget : TargetRules
{
	public GameCube1EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("GameCube1");
	}
}
