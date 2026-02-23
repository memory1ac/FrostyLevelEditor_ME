using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMoverEntityData))]
	public class PamMoverEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMoverEntityData>
	{
		public new FrostySdk.Ebx.PamMoverEntityData Data => data as FrostySdk.Ebx.PamMoverEntityData;
		public override string DisplayName => "PamMover";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamMoverEntity(FrostySdk.Ebx.PamMoverEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

