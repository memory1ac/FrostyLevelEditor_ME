using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIFrontEndEntityData))]
	public class PamUIFrontEndEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUIFrontEndEntityData>
	{
		public new FrostySdk.Ebx.PamUIFrontEndEntityData Data => data as FrostySdk.Ebx.PamUIFrontEndEntityData;
		public override string DisplayName => "PamUIFrontEnd";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUIFrontEndEntity(FrostySdk.Ebx.PamUIFrontEndEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

