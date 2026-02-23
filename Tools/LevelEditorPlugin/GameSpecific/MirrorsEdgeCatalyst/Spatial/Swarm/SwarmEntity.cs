using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SwarmEntityData))]
	public class SwarmEntity : GameComponentEntity, IEntityData<FrostySdk.Ebx.SwarmEntityData>
	{
		public new FrostySdk.Ebx.SwarmEntityData Data => data as FrostySdk.Ebx.SwarmEntityData;

		public SwarmEntity(FrostySdk.Ebx.SwarmEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

