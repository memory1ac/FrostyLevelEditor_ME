namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICommoRoseCommanderActionEntityData))]
public class UICommoRoseCommanderActionEntity : UICommoRoseActionEntity, IEntityData<FrostySdk.Ebx.UICommoRoseCommanderActionEntityData>
{
    public new FrostySdk.Ebx.UICommoRoseCommanderActionEntityData Data => data as FrostySdk.Ebx.UICommoRoseCommanderActionEntityData;
    public override string DisplayName => "UICommoRoseCommanderAction";

    public UICommoRoseCommanderActionEntity(FrostySdk.Ebx.UICommoRoseCommanderActionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

