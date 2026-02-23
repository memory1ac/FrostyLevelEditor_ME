namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIIMEntityData))]
public class UIIMEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIIMEntityData>
{
    public new FrostySdk.Ebx.UIIMEntityData Data => data as FrostySdk.Ebx.UIIMEntityData;
    public override string DisplayName => "UIIM";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIIMEntity(FrostySdk.Ebx.UIIMEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

