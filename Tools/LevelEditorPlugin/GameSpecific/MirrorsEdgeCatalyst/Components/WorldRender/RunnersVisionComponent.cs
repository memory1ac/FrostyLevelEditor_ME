
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.RunnersVisionComponentData))]
	public class RunnersVisionComponent : VisualEnvironmentComponent, IEntityData<FrostySdk.Ebx.RunnersVisionComponentData>
	{
		public new FrostySdk.Ebx.RunnersVisionComponentData Data => data as FrostySdk.Ebx.RunnersVisionComponentData;
		public override string DisplayName => "RunnersVisionComponent";

		public RunnersVisionComponent(FrostySdk.Ebx.RunnersVisionComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

