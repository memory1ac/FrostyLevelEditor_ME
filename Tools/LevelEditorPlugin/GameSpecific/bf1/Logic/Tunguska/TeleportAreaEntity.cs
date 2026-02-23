namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TeleportAreaEntityData))]
public class TeleportAreaEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TeleportAreaEntityData>
{
    public new FrostySdk.Ebx.TeleportAreaEntityData Data => data as FrostySdk.Ebx.TeleportAreaEntityData;
    public override string DisplayName => "TeleportArea";

    public TeleportAreaEntity(FrostySdk.Ebx.TeleportAreaEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

