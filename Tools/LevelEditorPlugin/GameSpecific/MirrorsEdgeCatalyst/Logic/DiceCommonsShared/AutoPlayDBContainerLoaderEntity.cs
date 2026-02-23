using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AutoPlayDBContainerLoaderEntityData))]
	public class AutoPlayDBContainerLoaderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AutoPlayDBContainerLoaderEntityData>
	{
		public new FrostySdk.Ebx.AutoPlayDBContainerLoaderEntityData Data => data as FrostySdk.Ebx.AutoPlayDBContainerLoaderEntityData;
		public override string DisplayName => "AutoPlayDBContainerLoader";

		public AutoPlayDBContainerLoaderEntity(FrostySdk.Ebx.AutoPlayDBContainerLoaderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

