using UnrealBuildTool;

public class openFAFTarget : TargetRules
{
	public openFAFTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("openFAF");
	}
}
