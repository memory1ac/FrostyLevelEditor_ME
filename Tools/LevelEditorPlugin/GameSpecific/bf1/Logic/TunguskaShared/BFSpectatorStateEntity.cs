namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSpectatorStateEntityData))]
public class BFSpectatorStateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFSpectatorStateEntityData>
{
    public new FrostySdk.Ebx.BFSpectatorStateEntityData Data => data as FrostySdk.Ebx.BFSpectatorStateEntityData;
    public override string DisplayName => "BFSpectatorState";

    public BFSpectatorStateEntity(FrostySdk.Ebx.BFSpectatorStateEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

