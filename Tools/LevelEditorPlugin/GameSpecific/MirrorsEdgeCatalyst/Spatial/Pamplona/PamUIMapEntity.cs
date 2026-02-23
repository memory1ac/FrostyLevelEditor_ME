using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIMapEntityData))]
	public class PamUIMapEntity : StaticModelEntity, IEntityData<FrostySdk.Ebx.PamUIMapEntityData>
	{
		public new FrostySdk.Ebx.PamUIMapEntityData Data => data as FrostySdk.Ebx.PamUIMapEntityData;

		public PamUIMapEntity(FrostySdk.Ebx.PamUIMapEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

