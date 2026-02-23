using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCountdownEntityData))]
	public class PamCountdownEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamCountdownEntityData>
	{
		public new FrostySdk.Ebx.PamCountdownEntityData Data => data as FrostySdk.Ebx.PamCountdownEntityData;
		public override string DisplayName => "PamCountdown";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamCountdownEntity(FrostySdk.Ebx.PamCountdownEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

