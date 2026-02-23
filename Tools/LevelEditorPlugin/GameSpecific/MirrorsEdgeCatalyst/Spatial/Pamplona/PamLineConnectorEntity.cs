using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamLineConnectorEntityData))]
	public class PamLineConnectorEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.PamLineConnectorEntityData>
	{
		public new FrostySdk.Ebx.PamLineConnectorEntityData Data => data as FrostySdk.Ebx.PamLineConnectorEntityData;

		public PamLineConnectorEntity(FrostySdk.Ebx.PamLineConnectorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

