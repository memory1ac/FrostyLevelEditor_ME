using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamGameViewStatusEntityData))]
	public class PamGameViewStatusEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamGameViewStatusEntityData>
	{
		public new FrostySdk.Ebx.PamGameViewStatusEntityData Data => data as FrostySdk.Ebx.PamGameViewStatusEntityData;
		public override string DisplayName => "PamGameViewStatus";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamGameViewStatusEntity(FrostySdk.Ebx.PamGameViewStatusEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

