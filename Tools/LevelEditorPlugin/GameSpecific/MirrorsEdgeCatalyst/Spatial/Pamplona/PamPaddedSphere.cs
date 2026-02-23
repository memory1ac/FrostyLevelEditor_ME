using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamPaddedSphereData))]
	public class PamPaddedSphere : LocatorEntity, IEntityData<FrostySdk.Ebx.PamPaddedSphereData>
	{
		public new FrostySdk.Ebx.PamPaddedSphereData Data => data as FrostySdk.Ebx.PamPaddedSphereData;
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamPaddedSphere(FrostySdk.Ebx.PamPaddedSphereData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

