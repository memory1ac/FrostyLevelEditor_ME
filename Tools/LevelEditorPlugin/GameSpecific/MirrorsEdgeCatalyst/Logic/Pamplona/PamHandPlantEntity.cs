using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamHandPlantEntityData))]
	public class PamHandPlantEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamHandPlantEntityData>
	{
		public new FrostySdk.Ebx.PamHandPlantEntityData Data => data as FrostySdk.Ebx.PamHandPlantEntityData;
		public override string DisplayName => "PamHandPlant";

		public PamHandPlantEntity(FrostySdk.Ebx.PamHandPlantEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

