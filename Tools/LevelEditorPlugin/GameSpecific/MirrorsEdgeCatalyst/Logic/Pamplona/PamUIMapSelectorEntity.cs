using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIMapSelectorEntityData))]
	public class PamUIMapSelectorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUIMapSelectorEntityData>
	{
		public new FrostySdk.Ebx.PamUIMapSelectorEntityData Data => data as FrostySdk.Ebx.PamUIMapSelectorEntityData;
		public override string DisplayName => "PamUIMapSelector";

		public PamUIMapSelectorEntity(FrostySdk.Ebx.PamUIMapSelectorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

