
using UnrealBuildTool;
using System.IO;
//using System;

public class HeliosObjects : ModuleRules
{
    public HeliosObjects(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        PrivatePCHHeaderFile = Path.Combine(ModuleDirectory, "HeliosObjectsPCH.h");
        DefaultBuildSettings = BuildSettingsVersion.V2;
        bUseUnity = false;
        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine",
            "HeadMountedDisplay",
            "SteamVR",
            "SteamVRInputDevice",});
        PrivateDependencyModuleNames.Add("VRExpansionPlugin");
        PrivateDependencyModuleNames.Add("BlueprintJson");
        PrivateDependencyModuleNames.Add("Settings");

        PublicIncludePaths.AddRange(
           new string[]
           {
                 ModuleDirectory,
                 Path.Combine(ModuleDirectory,"Public"),
                 Path.Combine(ModuleDirectory,"Public/HeliosDB")
                 

           });

        PrivateIncludePaths.AddRange(
            new string[]
            {
                 Path.Combine(ModuleDirectory,"Private"),
                 Path.Combine(ModuleDirectory,"Private/HeliosDB")
                // Path.Combine(ModuleDirectory,"Private")

            });
       // PublicDefinitions.Add("HELIOS_TEMPLATE=0");
        //string FPath = Path.Combine(ModuleDirectory, "HeliosEditor/Public");
        // Console.WriteLine(FPath);
        //Only if you created the Public and Private folder paths

    }
}