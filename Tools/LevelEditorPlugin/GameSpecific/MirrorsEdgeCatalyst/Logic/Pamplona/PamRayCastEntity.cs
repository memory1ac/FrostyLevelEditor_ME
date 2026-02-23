using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamRayCastEntityData))]
	public class PamRayCastEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamRayCastEntityData>
	{
		public new FrostySdk.Ebx.PamRayCastEntityData Data => data as FrostySdk.Ebx.PamRayCastEntityData;
		public override string DisplayName => "PamRayCast";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamRayCastEntity(FrostySdk.Ebx.PamRayCastEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

