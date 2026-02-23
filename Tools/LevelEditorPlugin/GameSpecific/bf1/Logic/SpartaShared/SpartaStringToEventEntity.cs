namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpartaStringToEventEntityData))]
public class SpartaStringToEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SpartaStringToEventEntityData>
{
    public new FrostySdk.Ebx.SpartaStringToEventEntityData Data => data as FrostySdk.Ebx.SpartaStringToEventEntityData;
    public override string DisplayName => "SpartaStringToEvent";

    public SpartaStringToEventEntity(FrostySdk.Ebx.SpartaStringToEventEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

