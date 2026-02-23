using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementVideoEntityData))]
	public class PamUIElementVideoEntity : UIElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementVideoEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementVideoEntityData Data => data as FrostySdk.Ebx.PamUIElementVideoEntityData;
		public override string DisplayName => "PamUIElementVideo";

		public PamUIElementVideoEntity(FrostySdk.Ebx.PamUIElementVideoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

