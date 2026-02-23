namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIEventLogDataProviderEntityData))]
public class UIEventLogDataProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIEventLogDataProviderEntityData>
{
    public new FrostySdk.Ebx.UIEventLogDataProviderEntityData Data => data as FrostySdk.Ebx.UIEventLogDataProviderEntityData;
    public override string DisplayName => "UIEventLogDataProvider";

    public UIEventLogDataProviderEntity(FrostySdk.Ebx.UIEventLogDataProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

