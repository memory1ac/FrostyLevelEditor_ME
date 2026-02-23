namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMatchEntityData))]
public class UIMatchEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIMatchEntityData>
{
    public new FrostySdk.Ebx.UIMatchEntityData Data => data as FrostySdk.Ebx.UIMatchEntityData;
    public override string DisplayName => "UIMatch";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIMatchEntity(FrostySdk.Ebx.UIMatchEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

