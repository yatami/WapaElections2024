// Copyright 2023 Qimera Corp. All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class QimeraV2Target : TargetRules
{
	public QimeraV2Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "QimeraV2" } );
	}
}
