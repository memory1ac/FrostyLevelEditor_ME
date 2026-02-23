
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCreatureLocoMotorComponentData))]
	public class PamCreatureLocoMotorComponent : CreatureLocoMotorComponent, IEntityData<FrostySdk.Ebx.PamCreatureLocoMotorComponentData>
	{
		public new FrostySdk.Ebx.PamCreatureLocoMotorComponentData Data => data as FrostySdk.Ebx.PamCreatureLocoMotorComponentData;
		public override string DisplayName => "PamCreatureLocoMotorComponent";

		public PamCreatureLocoMotorComponent(FrostySdk.Ebx.PamCreatureLocoMotorComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

