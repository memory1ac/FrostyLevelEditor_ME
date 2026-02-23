namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUISingleplayerProgressEntityData))]
public class BFUISingleplayerProgressEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUISingleplayerProgressEntityData>
{
    public new FrostySdk.Ebx.BFUISingleplayerProgressEntityData Data => data as FrostySdk.Ebx.BFUISingleplayerProgressEntityData;
    public override string DisplayName => "BFUISingleplayerProgress";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUISingleplayerProgressEntity(FrostySdk.Ebx.BFUISingleplayerProgressEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

