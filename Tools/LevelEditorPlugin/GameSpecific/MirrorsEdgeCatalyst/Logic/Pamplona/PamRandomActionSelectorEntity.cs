using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamRandomActionSelectorEntityData))]
	public class PamRandomActionSelectorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamRandomActionSelectorEntityData>
	{
		public new FrostySdk.Ebx.PamRandomActionSelectorEntityData Data => data as FrostySdk.Ebx.PamRandomActionSelectorEntityData;
		public override string DisplayName => "PamRandomActionSelector";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamRandomActionSelectorEntity(FrostySdk.Ebx.PamRandomActionSelectorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

