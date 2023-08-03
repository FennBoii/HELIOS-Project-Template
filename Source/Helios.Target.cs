// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class HeliosTarget : TargetRules
{
	public HeliosTarget(TargetInfo Target) : base(Target)
	{
        //bUseLoggingInShipping = true;
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        ExtraModuleNames.Add("Helios");
        ExtraModuleNames.Add("HeliosREGH");
        ExtraModuleNames.Add("HeliosObjects");
        
        bUsesSteam = true;
       // GlobalDefinitions.Add("UE4_PROJECT_STEAMGAMEDIR=\"Helios\"");
       // GlobalDefinitions.Add("UE4_PROJECT_STEAMSHIPPINGID=1047640");

       // ProjectDefinitions.Add("ONLINE_SUBSYSTEM_EOS_ENABLE_STEAM=1");

        //bUsePCHFiles = false;
        //bUseUnityBuild = false;
    }

    //
    // TargetRules interface.
    //

    /*public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "VRExpPluginExample" } );
	}*/
}
