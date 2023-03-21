// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Udemy1Tut2_ObstacleEditorTarget : TargetRules
{
	public Udemy1Tut2_ObstacleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Udemy1Tut2_Obstacle" } );
	}
}
