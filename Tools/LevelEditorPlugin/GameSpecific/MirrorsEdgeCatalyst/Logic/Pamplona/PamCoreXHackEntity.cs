using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCoreXHackEntityData))]
	public class PamCoreXHackEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamCoreXHackEntityData>
	{
		public new FrostySdk.Ebx.PamCoreXHackEntityData Data => data as FrostySdk.Ebx.PamCoreXHackEntityData;
		public override string DisplayName => "PamCoreXHack";

		public PamCoreXHackEntity(FrostySdk.Ebx.PamCoreXHackEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

