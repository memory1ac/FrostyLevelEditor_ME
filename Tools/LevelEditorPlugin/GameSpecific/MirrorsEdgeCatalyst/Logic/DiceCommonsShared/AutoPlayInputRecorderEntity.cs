using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AutoPlayInputRecorderEntityData))]
	public class AutoPlayInputRecorderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AutoPlayInputRecorderEntityData>
	{
		public new FrostySdk.Ebx.AutoPlayInputRecorderEntityData Data => data as FrostySdk.Ebx.AutoPlayInputRecorderEntityData;
		public override string DisplayName => "AutoPlayInputRecorder";

		public AutoPlayInputRecorderEntity(FrostySdk.Ebx.AutoPlayInputRecorderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

