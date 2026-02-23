namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICustomize3DModelEntityData))]
public class UICustomize3DModelEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UICustomize3DModelEntityData>
{
    public new FrostySdk.Ebx.UICustomize3DModelEntityData Data => data as FrostySdk.Ebx.UICustomize3DModelEntityData;
    public override string DisplayName => "UICustomize3DModel";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UICustomize3DModelEntity(FrostySdk.Ebx.UICustomize3DModelEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

