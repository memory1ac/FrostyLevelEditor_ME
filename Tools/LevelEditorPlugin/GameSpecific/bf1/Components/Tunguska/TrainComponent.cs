
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TrainComponentData))]
public class TrainComponent : ChassisComponent, IEntityData<FrostySdk.Ebx.TrainComponentData>
{
    public new FrostySdk.Ebx.TrainComponentData Data => data as FrostySdk.Ebx.TrainComponentData;
    public override string DisplayName => "TrainComponent";

    public TrainComponent(FrostySdk.Ebx.TrainComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

