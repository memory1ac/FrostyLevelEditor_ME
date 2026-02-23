using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamVideoOptionsEntityData))]
	public class PamVideoOptionsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamVideoOptionsEntityData>
	{
		public new FrostySdk.Ebx.PamVideoOptionsEntityData Data => data as FrostySdk.Ebx.PamVideoOptionsEntityData;
		public override string DisplayName => "PamVideoOptions";

		public PamVideoOptionsEntity(FrostySdk.Ebx.PamVideoOptionsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

