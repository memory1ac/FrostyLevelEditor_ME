using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamDelayEntityData))]
	public class PamDelayEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamDelayEntityData>
	{
		public new FrostySdk.Ebx.PamDelayEntityData Data => data as FrostySdk.Ebx.PamDelayEntityData;
		public override string DisplayName => "PamDelay";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamDelayEntity(FrostySdk.Ebx.PamDelayEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

