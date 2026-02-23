namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIDeployUtilEntityData))]
public class UIDeployUtilEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIDeployUtilEntityData>
{
    public new FrostySdk.Ebx.UIDeployUtilEntityData Data => data as FrostySdk.Ebx.UIDeployUtilEntityData;
    public override string DisplayName => "UIDeployUtil";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIDeployUtilEntity(FrostySdk.Ebx.UIDeployUtilEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

