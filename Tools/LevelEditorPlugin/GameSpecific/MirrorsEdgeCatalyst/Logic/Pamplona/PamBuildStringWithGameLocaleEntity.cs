using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamBuildStringWithGameLocaleEntityData))]
	public class PamBuildStringWithGameLocaleEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamBuildStringWithGameLocaleEntityData>
	{
		public new FrostySdk.Ebx.PamBuildStringWithGameLocaleEntityData Data => data as FrostySdk.Ebx.PamBuildStringWithGameLocaleEntityData;
		public override string DisplayName => "PamBuildStringWithGameLocale";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamBuildStringWithGameLocaleEntity(FrostySdk.Ebx.PamBuildStringWithGameLocaleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

