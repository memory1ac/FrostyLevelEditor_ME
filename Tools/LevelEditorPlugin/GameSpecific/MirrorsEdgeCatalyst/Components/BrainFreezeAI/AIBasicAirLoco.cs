
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIBasicAirLocoData))]
	public class AIBasicAirLoco : LocoComponent, IEntityData<FrostySdk.Ebx.AIBasicAirLocoData>
	{
		public new FrostySdk.Ebx.AIBasicAirLocoData Data => data as FrostySdk.Ebx.AIBasicAirLocoData;
		public override string DisplayName => "AIBasicAirLoco";

		public AIBasicAirLoco(FrostySdk.Ebx.AIBasicAirLocoData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

