namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DoorEntityData))]
public class DoorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DoorEntityData>
{
    public new FrostySdk.Ebx.DoorEntityData Data => data as FrostySdk.Ebx.DoorEntityData;
    public override string DisplayName => "Door";

    public DoorEntity(FrostySdk.Ebx.DoorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

