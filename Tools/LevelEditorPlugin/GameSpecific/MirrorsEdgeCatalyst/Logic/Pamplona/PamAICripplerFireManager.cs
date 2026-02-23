using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAICripplerFireManagerData))]
	public class PamAICripplerFireManager : PamAIFireManagerBase, IEntityData<FrostySdk.Ebx.PamAICripplerFireManagerData>
	{
		public new FrostySdk.Ebx.PamAICripplerFireManagerData Data => data as FrostySdk.Ebx.PamAICripplerFireManagerData;
		public override string DisplayName => "PamAICripplerFireManager";

		public PamAICripplerFireManager(FrostySdk.Ebx.PamAICripplerFireManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

