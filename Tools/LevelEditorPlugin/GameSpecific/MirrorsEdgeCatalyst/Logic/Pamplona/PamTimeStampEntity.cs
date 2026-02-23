using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamTimeStampEntityData))]
	public class PamTimeStampEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamTimeStampEntityData>
	{
		public new FrostySdk.Ebx.PamTimeStampEntityData Data => data as FrostySdk.Ebx.PamTimeStampEntityData;
		public override string DisplayName => "PamTimeStamp";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamTimeStampEntity(FrostySdk.Ebx.PamTimeStampEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

