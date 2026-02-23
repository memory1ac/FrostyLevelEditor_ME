namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIStatEventCompareEntityData))]
public class UIStatEventCompareEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIStatEventCompareEntityData>
{
    public new FrostySdk.Ebx.UIStatEventCompareEntityData Data => data as FrostySdk.Ebx.UIStatEventCompareEntityData;
    public override string DisplayName => "UIStatEventCompare";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIStatEventCompareEntity(FrostySdk.Ebx.UIStatEventCompareEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

