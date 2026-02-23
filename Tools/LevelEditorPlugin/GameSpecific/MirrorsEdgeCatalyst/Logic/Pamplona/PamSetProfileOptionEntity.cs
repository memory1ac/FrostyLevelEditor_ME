using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSetProfileOptionEntityData))]
	public class PamSetProfileOptionEntity : PamProfileOptionEntity, IEntityData<FrostySdk.Ebx.PamSetProfileOptionEntityData>
	{
		public new FrostySdk.Ebx.PamSetProfileOptionEntityData Data => data as FrostySdk.Ebx.PamSetProfileOptionEntityData;
		public override string DisplayName => "PamSetProfileOption";

		public PamSetProfileOptionEntity(FrostySdk.Ebx.PamSetProfileOptionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

