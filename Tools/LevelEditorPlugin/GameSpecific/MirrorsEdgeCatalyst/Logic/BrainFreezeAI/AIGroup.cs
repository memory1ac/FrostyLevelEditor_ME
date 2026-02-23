using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIGroupData))]
	public class AIGroup : LogicEntity, IEntityData<FrostySdk.Ebx.AIGroupData>
	{
		public new FrostySdk.Ebx.AIGroupData Data => data as FrostySdk.Ebx.AIGroupData;
		public override string DisplayName => "AIGroup";

		public AIGroup(FrostySdk.Ebx.AIGroupData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

