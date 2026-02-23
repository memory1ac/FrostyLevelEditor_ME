using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamProfileOptionEntityData))]
	public class PamProfileOptionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamProfileOptionEntityData>
	{
		public new FrostySdk.Ebx.PamProfileOptionEntityData Data => data as FrostySdk.Ebx.PamProfileOptionEntityData;
		public override string DisplayName => "PamProfileOption";

		public PamProfileOptionEntity(FrostySdk.Ebx.PamProfileOptionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

