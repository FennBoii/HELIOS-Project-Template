
using UnrealBuildTool;
using System.IO;
//using System;

public class HeliosREGH : ModuleRules
{
    public HeliosREGH(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        PrivatePCHHeaderFile = Path.Combine(ModuleDirectory, "HeliosREGHPCH.h");
        DefaultBuildSettings = BuildSettingsVersion.V2;
        bUseUnity = false;
        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "Helios","HeliosObjects"

        });

        PublicIncludePaths.AddRange(
           new string[]
           {
                 ModuleDirectory,
                 Path.Combine(ModuleDirectory,"Public")
                 

           });

        PrivateIncludePaths.AddRange(
            new string[]
            {
                 Path.Combine(ModuleDirectory,"Private"),
                // Path.Combine(ModuleDirectory,"Private")

            });
        //string FPath = Path.Combine(ModuleDirectory, "HeliosEditor/Public");
        // Console.WriteLine(FPath);
        //Only if you created the Public and Private folder paths

    }
}