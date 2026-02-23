namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIOperationInfoEntityData))]
public class UIOperationInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIOperationInfoEntityData>
{
    public new FrostySdk.Ebx.UIOperationInfoEntityData Data => data as FrostySdk.Ebx.UIOperationInfoEntityData;
    public override string DisplayName => "UIOperationInfo";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIOperationInfoEntity(FrostySdk.Ebx.UIOperationInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

