using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateStayAtAssignedPosData))]
	public class PamAIStateStayAtAssignedPos : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateStayAtAssignedPosData>
	{
		public new FrostySdk.Ebx.PamAIStateStayAtAssignedPosData Data => data as FrostySdk.Ebx.PamAIStateStayAtAssignedPosData;
		public override string DisplayName => "PamAIStateStayAtAssignedPos";

		public PamAIStateStayAtAssignedPos(FrostySdk.Ebx.PamAIStateStayAtAssignedPosData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

