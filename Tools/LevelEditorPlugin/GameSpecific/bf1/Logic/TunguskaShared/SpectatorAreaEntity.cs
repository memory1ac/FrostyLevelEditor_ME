namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpectatorAreaEntityData))]
public class SpectatorAreaEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SpectatorAreaEntityData>
{
    public new FrostySdk.Ebx.SpectatorAreaEntityData Data => data as FrostySdk.Ebx.SpectatorAreaEntityData;
    public override string DisplayName => "SpectatorArea";

    public SpectatorAreaEntity(FrostySdk.Ebx.SpectatorAreaEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

