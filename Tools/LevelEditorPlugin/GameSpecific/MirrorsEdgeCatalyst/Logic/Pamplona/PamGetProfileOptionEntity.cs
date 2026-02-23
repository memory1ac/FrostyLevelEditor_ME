using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamGetProfileOptionEntityData))]
	public class PamGetProfileOptionEntity : PamProfileOptionEntity, IEntityData<FrostySdk.Ebx.PamGetProfileOptionEntityData>
	{
		public new FrostySdk.Ebx.PamGetProfileOptionEntityData Data => data as FrostySdk.Ebx.PamGetProfileOptionEntityData;
		public override string DisplayName => "PamGetProfileOption";

		public PamGetProfileOptionEntity(FrostySdk.Ebx.PamGetProfileOptionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

