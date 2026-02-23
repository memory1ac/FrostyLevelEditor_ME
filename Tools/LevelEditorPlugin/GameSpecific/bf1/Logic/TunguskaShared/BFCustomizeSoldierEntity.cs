namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFCustomizeSoldierEntityData))]
public class BFCustomizeSoldierEntity : CustomizeSoldierEntity, IEntityData<FrostySdk.Ebx.BFCustomizeSoldierEntityData>
{
    public new FrostySdk.Ebx.BFCustomizeSoldierEntityData Data => data as FrostySdk.Ebx.BFCustomizeSoldierEntityData;
    public override string DisplayName => "BFCustomizeSoldier";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFCustomizeSoldierEntity(FrostySdk.Ebx.BFCustomizeSoldierEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

