namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIDebugEntityData))]
public class UIDebugEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIDebugEntityData>
{
    public new FrostySdk.Ebx.UIDebugEntityData Data => data as FrostySdk.Ebx.UIDebugEntityData;
    public override string DisplayName => "UIDebug";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIDebugEntity(FrostySdk.Ebx.UIDebugEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

