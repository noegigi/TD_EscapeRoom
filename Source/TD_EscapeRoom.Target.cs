// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class TD_EscapeRoomTarget : TargetRules
{
	public TD_EscapeRoomTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "TD_EscapeRoom" } );
	}
}
