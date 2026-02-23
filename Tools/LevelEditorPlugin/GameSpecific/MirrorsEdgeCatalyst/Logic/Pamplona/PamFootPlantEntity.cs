using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamFootPlantEntityData))]
	public class PamFootPlantEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamFootPlantEntityData>
	{
		public new FrostySdk.Ebx.PamFootPlantEntityData Data => data as FrostySdk.Ebx.PamFootPlantEntityData;
		public override string DisplayName => "PamFootPlant";

		public PamFootPlantEntity(FrostySdk.Ebx.PamFootPlantEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

