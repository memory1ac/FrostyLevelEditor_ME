using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamStaticModelEntityData))]
	public class PamStaticModelEntity : StaticModelEntity, IEntityData<FrostySdk.Ebx.PamStaticModelEntityData>
	{
		public new FrostySdk.Ebx.PamStaticModelEntityData Data => data as FrostySdk.Ebx.PamStaticModelEntityData;

		public PamStaticModelEntity(FrostySdk.Ebx.PamStaticModelEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

