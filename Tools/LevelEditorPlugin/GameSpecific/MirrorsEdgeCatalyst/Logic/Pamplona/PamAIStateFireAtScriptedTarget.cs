using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateFireAtScriptedTargetData))]
	public class PamAIStateFireAtScriptedTarget : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateFireAtScriptedTargetData>
	{
		public new FrostySdk.Ebx.PamAIStateFireAtScriptedTargetData Data => data as FrostySdk.Ebx.PamAIStateFireAtScriptedTargetData;
		public override string DisplayName => "PamAIStateFireAtScriptedTarget";

		public PamAIStateFireAtScriptedTarget(FrostySdk.Ebx.PamAIStateFireAtScriptedTargetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

