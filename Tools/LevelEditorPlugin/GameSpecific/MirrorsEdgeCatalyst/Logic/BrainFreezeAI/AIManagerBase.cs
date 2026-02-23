using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIManagerBaseData))]
	public class AIManagerBase : LogicEntity, IEntityData<FrostySdk.Ebx.AIManagerBaseData>
	{
		public new FrostySdk.Ebx.AIManagerBaseData Data => data as FrostySdk.Ebx.AIManagerBaseData;
		public override string DisplayName => "AIManagerBase";

		public AIManagerBase(FrostySdk.Ebx.AIManagerBaseData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

