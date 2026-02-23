using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamControllerRumbleEntityData))]
	public class PamControllerRumbleEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamControllerRumbleEntityData>
	{
		public new FrostySdk.Ebx.PamControllerRumbleEntityData Data => data as FrostySdk.Ebx.PamControllerRumbleEntityData;
		public override string DisplayName => "PamControllerRumble";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamControllerRumbleEntity(FrostySdk.Ebx.PamControllerRumbleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

