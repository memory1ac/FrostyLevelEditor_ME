namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.InspectEntityData))]
public class InspectEntity : LogicEntity, IEntityData<FrostySdk.Ebx.InspectEntityData>
{
    public new FrostySdk.Ebx.InspectEntityData Data => data as FrostySdk.Ebx.InspectEntityData;
    public override string DisplayName => "Inspect";

    public InspectEntity(FrostySdk.Ebx.InspectEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

