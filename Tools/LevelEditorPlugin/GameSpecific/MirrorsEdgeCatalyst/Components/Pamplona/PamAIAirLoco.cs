
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIAirLocoData))]
	public class PamAIAirLoco : AIBasicAirLoco, IEntityData<FrostySdk.Ebx.PamAIAirLocoData>
	{
		public new FrostySdk.Ebx.PamAIAirLocoData Data => data as FrostySdk.Ebx.PamAIAirLocoData;
		public override string DisplayName => "PamAIAirLoco";

		public PamAIAirLoco(FrostySdk.Ebx.PamAIAirLocoData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

