using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamProjectionCustomizationHashProviderEntityData))]
	public class PamProjectionCustomizationHashProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamProjectionCustomizationHashProviderEntityData>
	{
		public new FrostySdk.Ebx.PamProjectionCustomizationHashProviderEntityData Data => data as FrostySdk.Ebx.PamProjectionCustomizationHashProviderEntityData;
		public override string DisplayName => "PamProjectionCustomizationHashProvider";

		public PamProjectionCustomizationHashProviderEntity(FrostySdk.Ebx.PamProjectionCustomizationHashProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

