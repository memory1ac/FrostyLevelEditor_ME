namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIShowPlayerProfileEntityData))]
public class UIShowPlayerProfileEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIShowPlayerProfileEntityData>
{
    public new FrostySdk.Ebx.UIShowPlayerProfileEntityData Data => data as FrostySdk.Ebx.UIShowPlayerProfileEntityData;
    public override string DisplayName => "UIShowPlayerProfile";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIShowPlayerProfileEntity(FrostySdk.Ebx.UIShowPlayerProfileEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

