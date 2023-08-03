// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
//using System.Collections.Generic;

public class HeliosEditorTarget : TargetRules
{
	public HeliosEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        //   PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        ExtraModuleNames.AddRange(new string[] { "Helios","HeliosEditor"});
        bUsesSteam = true;

       // PublicDependencyModuleNames.AddRange(new string[] { "Helios" });

        //PublicIncludePaths.AddRange(
        //    new string[]
        //    {
        //        "HeliosEditor/Public"
        //    });

        //PrivateIncludePaths.AddRange(
        //    new string[]
        //    {
        //        "HeliosEditor/Private"
        //    });

        //  DefaultBuildSettings = BuildSettingsVersion.V2;
        //bUseUnityBuild = false;
        //bUsePCHFiles = false;
    }

	//
	// TargetRules interface.
	//

/*	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "VRExpPluginExample" } );
	}*/
}
