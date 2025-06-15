// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Otus_5_5_4 : ModuleRules
{
	public Otus_5_5_4(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
