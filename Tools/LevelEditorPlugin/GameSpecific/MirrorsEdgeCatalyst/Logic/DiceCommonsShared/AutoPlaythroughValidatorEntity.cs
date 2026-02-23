using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AutoPlaythroughValidatorEntityData))]
	public class AutoPlaythroughValidatorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AutoPlaythroughValidatorEntityData>
	{
		public new FrostySdk.Ebx.AutoPlaythroughValidatorEntityData Data => data as FrostySdk.Ebx.AutoPlaythroughValidatorEntityData;
		public override string DisplayName => "AutoPlaythroughValidator";

		public AutoPlaythroughValidatorEntity(FrostySdk.Ebx.AutoPlaythroughValidatorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

