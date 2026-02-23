namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIHWInputToActionEntityData))]
public class BFUIHWInputToActionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIHWInputToActionEntityData>
{
    public new FrostySdk.Ebx.BFUIHWInputToActionEntityData Data => data as FrostySdk.Ebx.BFUIHWInputToActionEntityData;
    public override string DisplayName => "BFUIHWInputToAction";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIHWInputToActionEntity(FrostySdk.Ebx.BFUIHWInputToActionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

