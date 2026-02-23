namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetPlayerEntityData))]
public class BFUIGetPlayerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetPlayerEntityData>
{
    public new FrostySdk.Ebx.BFUIGetPlayerEntityData Data => data as FrostySdk.Ebx.BFUIGetPlayerEntityData;
    public override string DisplayName => "BFUIGetPlayer";

    public BFUIGetPlayerEntity(FrostySdk.Ebx.BFUIGetPlayerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

