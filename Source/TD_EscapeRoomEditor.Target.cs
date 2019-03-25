// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class TD_EscapeRoomEditorTarget : TargetRules
{
	public TD_EscapeRoomEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "TD_EscapeRoom" } );
	}
}
