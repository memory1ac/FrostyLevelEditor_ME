
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LocoComponentData))]
	public class LocoComponent : GameComponent, IEntityData<FrostySdk.Ebx.LocoComponentData>
	{
		public new FrostySdk.Ebx.LocoComponentData Data => data as FrostySdk.Ebx.LocoComponentData;
		public override string DisplayName => "LocoComponent";

		public LocoComponent(FrostySdk.Ebx.LocoComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

