using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AISpecializationEntityData))]
	public class AISpecializationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AISpecializationEntityData>
	{
		public new FrostySdk.Ebx.AISpecializationEntityData Data => data as FrostySdk.Ebx.AISpecializationEntityData;
		public override string DisplayName => "AISpecialization";

		public AISpecializationEntity(FrostySdk.Ebx.AISpecializationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

