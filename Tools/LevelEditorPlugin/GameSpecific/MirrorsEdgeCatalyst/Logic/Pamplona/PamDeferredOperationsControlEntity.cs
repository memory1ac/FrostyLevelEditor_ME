using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamDeferredOperationsControlEntityData))]
	public class PamDeferredOperationsControlEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamDeferredOperationsControlEntityData>
	{
		public new FrostySdk.Ebx.PamDeferredOperationsControlEntityData Data => data as FrostySdk.Ebx.PamDeferredOperationsControlEntityData;
		public override string DisplayName => "PamDeferredOperationsControl";

		public PamDeferredOperationsControlEntity(FrostySdk.Ebx.PamDeferredOperationsControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

