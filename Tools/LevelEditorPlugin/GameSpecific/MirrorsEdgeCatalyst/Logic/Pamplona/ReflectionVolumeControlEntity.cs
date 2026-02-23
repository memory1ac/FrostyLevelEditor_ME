using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ReflectionVolumeControlEntityData))]
	public class ReflectionVolumeControlEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ReflectionVolumeControlEntityData>
	{
		public new FrostySdk.Ebx.ReflectionVolumeControlEntityData Data => data as FrostySdk.Ebx.ReflectionVolumeControlEntityData;
		public override string DisplayName => "ReflectionVolumeControl";

		public ReflectionVolumeControlEntity(FrostySdk.Ebx.ReflectionVolumeControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

