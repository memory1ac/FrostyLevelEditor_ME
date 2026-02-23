using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AffineProjectionData))]
	public class AffineProjection : LogicEntity, IEntityData<FrostySdk.Ebx.AffineProjectionData>
	{
		public new FrostySdk.Ebx.AffineProjectionData Data => data as FrostySdk.Ebx.AffineProjectionData;
		public override string DisplayName => "AffineProjection";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public AffineProjection(FrostySdk.Ebx.AffineProjectionData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

