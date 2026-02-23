namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ShuffleIntEntityData))]
public class ShuffleIntEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ShuffleIntEntityData>
{
    public new FrostySdk.Ebx.ShuffleIntEntityData Data => data as FrostySdk.Ebx.ShuffleIntEntityData;
    public override string DisplayName => "ShuffleInt";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public ShuffleIntEntity(FrostySdk.Ebx.ShuffleIntEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

