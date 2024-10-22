// Copyright 2023 Qimera Corp. All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class QimeraV2EditorTarget : TargetRules
{
	public QimeraV2EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "QimeraV2" } );
	}
}
