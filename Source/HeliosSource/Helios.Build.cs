// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.IO;
using System;
using Tools.DotNETCommon;
public class Helios : ModuleRules
{
	public Helios(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        bUseUnity = false;
        PublicDependencyModuleNames.AddRange(new string[] { "Core",
            "CoreUObject",
            "Engine",
            "InputCore",
          //  "HeliosREGH",
            "HeliosObjects",
            "GameplayTags",
            "AdvancedSessions",
            "VRExpansionPlugin",
            "OpenVRExpansionPlugin",
            "AssetRegistry",
            "OnlineSubsystem",
            "OnlineSubsystemUtils",
            "Voice",
            "OVRLipSync",
            "VRIKBodyRuntime",
            "DiscordRichPresence",
            "PakFile",
            "Networking",
            "ApplicationCore",
            "HeadMountedDisplay",
            "SlateCore",
            "AIModule",
             "DeveloperSettings",
            "Http",
            "MediaAssets",
            "PakLoader",
            "BlueprintJson",
            "UMG",
            //"SCUE4",
            "SteamVR",
            "SteamVRInputDevice",
            "SteamWorkshop",
            "Steamworks", "SteamGeneral",
            "Json","JsonUtilities" });

       // string BaseDirectory = Path.GetFullPath(Path.Combine(ModuleDirectory, "..", ".."));
      //  BaseDirectory = Path.Combine(BaseDirectory, "Plugins" , "VRIKBody","Source", "VRIKBodyRuntime", "Public");
       // Log.TraceInformation(BaseDirectory);

        PublicDefinitions.Add("WITH_OGGVORBIS=1");
        PublicDefinitions.Add("HELIOS_TEMPLATE=1");
        PrivateDependencyModuleNames.AddRange(new string[] { "Core",
            "CoreUObject",
            "Engine",
            "InputCore",
            "HeliosObjects",
            "VRIKBodyRuntime",
            "AdvancedSessions",
           // "HeliosObjects",
            "VRExpansionPlugin",
            "OnlineSubsystem",
            "OnlineSubsystemUtils",
            //"VivoxCore"
             });
        //AddEngineThirdPartyPrivateStaticDependencies(Target, "Steamworks");
        // DynamicallyLoadedModuleNames.Add("OnlineSubsystemSteam");
        if (Target.bBuildEditor == true)
        {
            PrivateDependencyModuleNames.AddRange(
                new string[] { 
            "AnimGraph",
            "AnimGraphRunTime",
            "OVRLipSyncEditor",
            "ContentBrowser"         
                }
            );
        }

        DynamicallyLoadedModuleNames.Add("OnlineSubsystemSteam");
        DynamicallyLoadedModuleNames.Add("HeliosREGH");
       // DynamicallyLoadedModuleNames.Add("VRIKBodyRuntime");
        if (Target.bBuildEditor == true)
        {
            PrivateDependencyModuleNames.AddRange(
                new string[] { "AnimGraphRunTime",

                }
            );
        }
        PublicIncludePaths.AddRange(
            new string[]
            {
                 Path.Combine(ModuleDirectory,"Public/Widgets/Public"),
                 Path.Combine(ModuleDirectory,"Public/Widgets"),
                 Path.Combine(ModuleDirectory,"Public"),
                 Path.Combine(ModuleDirectory,"Public/GripScripts"),
                 Path.Combine(ModuleDirectory,"UTubePlayer/Public"),
                 Path.Combine(ModuleDirectory,"MMTPort"),
                 Path.Combine(ModuleDirectory,"HSteam/Public"),
                 Path.Combine(ModuleDirectory,"AnimNodes/Public"),
                // BaseDirectory,
                 ModuleDirectory
            });

        PrivateIncludePaths.AddRange(
            new string[]
            {
                 Path.Combine(ModuleDirectory,"Private/Widgets/Public"),
                 Path.Combine(ModuleDirectory,"Private/Widgets"),
                 Path.Combine(ModuleDirectory,"UTubePlayer/Private"),
                 Path.Combine(ModuleDirectory,"Private/GripScripts"),
                 Path.Combine(ModuleDirectory,"MMTPort"),
                 Path.Combine(ModuleDirectory,"HSteam/Private"),
                 //Path.Combine(ModuleDirectory,"Vivox/Public")
            });

        // PublicAdditionalLibraries.Add("V://Helios//Binaries//Win64//discord_game_sdk.dll.lib");

    }
}
