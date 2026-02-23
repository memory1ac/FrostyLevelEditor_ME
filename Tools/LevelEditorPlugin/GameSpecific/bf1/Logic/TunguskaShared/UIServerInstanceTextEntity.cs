namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIServerInstanceTextEntityData))]
public class UIServerInstanceTextEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIServerInstanceTextEntityData>
{
    public new FrostySdk.Ebx.UIServerInstanceTextEntityData Data => data as FrostySdk.Ebx.UIServerInstanceTextEntityData;
    public override string DisplayName => "UIServerInstanceText";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIServerInstanceTextEntity(FrostySdk.Ebx.UIServerInstanceTextEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

