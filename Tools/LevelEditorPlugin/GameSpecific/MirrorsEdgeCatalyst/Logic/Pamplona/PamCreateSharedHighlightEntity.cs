using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCreateSharedHighlightEntityData))]
	public class PamCreateSharedHighlightEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamCreateSharedHighlightEntityData>
	{
		public new FrostySdk.Ebx.PamCreateSharedHighlightEntityData Data => data as FrostySdk.Ebx.PamCreateSharedHighlightEntityData;
		public override string DisplayName => "PamCreateSharedHighlight";

		public PamCreateSharedHighlightEntity(FrostySdk.Ebx.PamCreateSharedHighlightEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

