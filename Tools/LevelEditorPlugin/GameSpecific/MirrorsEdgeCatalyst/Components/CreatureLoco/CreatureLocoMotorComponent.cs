
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CreatureLocoMotorComponentData))]
	public class CreatureLocoMotorComponent : LocoComponent, IEntityData<FrostySdk.Ebx.CreatureLocoMotorComponentData>
	{
		public new FrostySdk.Ebx.CreatureLocoMotorComponentData Data => data as FrostySdk.Ebx.CreatureLocoMotorComponentData;
		public override string DisplayName => "CreatureLocoMotorComponent";

		public CreatureLocoMotorComponent(FrostySdk.Ebx.CreatureLocoMotorComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

