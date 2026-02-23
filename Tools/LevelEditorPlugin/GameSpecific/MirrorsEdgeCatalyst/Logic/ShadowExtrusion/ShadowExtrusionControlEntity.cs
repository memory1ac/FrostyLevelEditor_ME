using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ShadowExtrusionControlEntityData))]
	public class ShadowExtrusionControlEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ShadowExtrusionControlEntityData>
	{
		public new FrostySdk.Ebx.ShadowExtrusionControlEntityData Data => data as FrostySdk.Ebx.ShadowExtrusionControlEntityData;
		public override string DisplayName => "ShadowExtrusionControl";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ShadowExtrusionControlEntity(FrostySdk.Ebx.ShadowExtrusionControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

