namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIEventLogDataFilterEntityData))]
public class UIEventLogDataFilterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIEventLogDataFilterEntityData>
{
    public new FrostySdk.Ebx.UIEventLogDataFilterEntityData Data => data as FrostySdk.Ebx.UIEventLogDataFilterEntityData;
    public override string DisplayName => "UIEventLogDataFilter";

    public UIEventLogDataFilterEntity(FrostySdk.Ebx.UIEventLogDataFilterEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

