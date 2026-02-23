using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementRadialBarEntityData))]
	public class PamUIElementRadialBarEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementRadialBarEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementRadialBarEntityData Data => data as FrostySdk.Ebx.PamUIElementRadialBarEntityData;
		public override string DisplayName => "PamUIElementRadialBar";

		public PamUIElementRadialBarEntity(FrostySdk.Ebx.PamUIElementRadialBarEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

