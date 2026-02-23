namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICommoRoseActionEntityData))]
public class UICommoRoseActionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UICommoRoseActionEntityData>
{
    public new FrostySdk.Ebx.UICommoRoseActionEntityData Data => data as FrostySdk.Ebx.UICommoRoseActionEntityData;
    public override string DisplayName => "UICommoRoseAction";

    public UICommoRoseActionEntity(FrostySdk.Ebx.UICommoRoseActionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

