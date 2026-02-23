
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.EMPTargetComponentData))]
public class EMPTargetComponent : GameComponent, IEntityData<FrostySdk.Ebx.EMPTargetComponentData>
{
    public new FrostySdk.Ebx.EMPTargetComponentData Data => data as FrostySdk.Ebx.EMPTargetComponentData;
    public override string DisplayName => "EMPTargetComponent";

    public EMPTargetComponent(FrostySdk.Ebx.EMPTargetComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

