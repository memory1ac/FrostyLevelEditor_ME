using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSharedContentBlockEntityData))]
	public class PamSharedContentBlockEntity : PamPaddedSphere, IEntityData<FrostySdk.Ebx.PamSharedContentBlockEntityData>
	{
		public new FrostySdk.Ebx.PamSharedContentBlockEntityData Data => data as FrostySdk.Ebx.PamSharedContentBlockEntityData;
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamSharedContentBlockEntity(FrostySdk.Ebx.PamSharedContentBlockEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

