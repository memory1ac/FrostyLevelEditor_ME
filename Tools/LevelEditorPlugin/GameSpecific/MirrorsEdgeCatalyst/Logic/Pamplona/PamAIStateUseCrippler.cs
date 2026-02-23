using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateUseCripplerData))]
	public class PamAIStateUseCrippler : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateUseCripplerData>
	{
		public new FrostySdk.Ebx.PamAIStateUseCripplerData Data => data as FrostySdk.Ebx.PamAIStateUseCripplerData;
		public override string DisplayName => "PamAIStateUseCrippler";

		public PamAIStateUseCrippler(FrostySdk.Ebx.PamAIStateUseCripplerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

