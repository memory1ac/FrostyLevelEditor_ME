using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TransformVelocityData))]
	public class TransformVelocity : LogicEntity, IEntityData<FrostySdk.Ebx.TransformVelocityData>
	{
		public new FrostySdk.Ebx.TransformVelocityData Data => data as FrostySdk.Ebx.TransformVelocityData;
		public override string DisplayName => "TransformVelocity";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public TransformVelocity(FrostySdk.Ebx.TransformVelocityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

