using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSphereCollisionEntityData))]
	public class PamSphereCollisionEntity : SphereCollisionEntity, IEntityData<FrostySdk.Ebx.PamSphereCollisionEntityData>
	{
		public new FrostySdk.Ebx.PamSphereCollisionEntityData Data => data as FrostySdk.Ebx.PamSphereCollisionEntityData;

		public PamSphereCollisionEntity(FrostySdk.Ebx.PamSphereCollisionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

