
using UnrealBuildTool;
using System.IO;
//using System;

public class HeliosEditor : ModuleRules
{
    public HeliosEditor(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

       // bUseUnity = false;
        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "AssetTools",
             "AnimGraph",
            "AnimGraphRuntime",
            "BlueprintJson",
            "BlueprintGraph",
            "UMG",
            "MainFrame"
        });

        PublicDependencyModuleNames.AddRange(new string[] { "Helios","HeliosObjects" });

        PrivateDependencyModuleNames.AddRange(new string[] { "SlateCore",

            "Slate",
            "UMG",
            "Engine",
            "Helios",
            "EditorStyle",
            "EditorWidgets",
            "EditorScriptingUtilities",
            "AnimGraph",
            "AnimGraphRuntime",
            "BlueprintGraph",
            "AssetRegistry",
            "VRIKBodyRuntime",
            "VRIKBodyEditor",
            "Projects",
            "Persona",
            "PropertyEditor",
            "UnrealEd",
            "MessageLog",
            //"PakFileUtilities",
            "ElgEditorScripting",
            //"LauncherServices"

        });
       
        PublicIncludePaths.AddRange(
           new string[]
           {
                 Path.Combine(ModuleDirectory,"Public"),
                 Path.Combine(ModuleDirectory,"AnimNodes/Public"),
                 Path.Combine(ModuleDirectory,"Widgets"),
                 ModuleDirectory

           });

        PrivateIncludePaths.AddRange(
            new string[]
            {
                 Path.Combine(ModuleDirectory,"Private"),
                   Path.Combine(ModuleDirectory,"AnimNodes/Private"),
                 Path.Combine(ModuleDirectory,"Widgets")
                // Path.Combine(ModuleDirectory,"Private")

            });
        //string FPath = Path.Combine(ModuleDirectory, "HeliosEditor/Public");
        // Console.WriteLine(FPath);
        //Only if you created the Public and Private folder paths

    }
}