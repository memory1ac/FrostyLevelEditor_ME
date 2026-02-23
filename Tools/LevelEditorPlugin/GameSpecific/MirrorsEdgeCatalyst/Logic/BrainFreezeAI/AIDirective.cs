using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIDirectiveData))]
	public class AIDirective : LogicEntity, IEntityData<FrostySdk.Ebx.AIDirectiveData>
	{
		public new FrostySdk.Ebx.AIDirectiveData Data => data as FrostySdk.Ebx.AIDirectiveData;
		public override string DisplayName => "AIDirective";

		public AIDirective(FrostySdk.Ebx.AIDirectiveData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

