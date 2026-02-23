using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamProgressionFlagEntityData))]
	public class PamProgressionFlagEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamProgressionFlagEntityData>
	{
		public new FrostySdk.Ebx.PamProgressionFlagEntityData Data => data as FrostySdk.Ebx.PamProgressionFlagEntityData;
		public override string DisplayName => "PamProgressionFlag";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamProgressionFlagEntity(FrostySdk.Ebx.PamProgressionFlagEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

