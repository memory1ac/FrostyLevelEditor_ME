using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementGadgetSelectorEntityData))]
	public class PamUIElementGadgetSelectorEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementGadgetSelectorEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementGadgetSelectorEntityData Data => data as FrostySdk.Ebx.PamUIElementGadgetSelectorEntityData;
		public override string DisplayName => "PamUIElementGadgetSelector";

		public PamUIElementGadgetSelectorEntity(FrostySdk.Ebx.PamUIElementGadgetSelectorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

