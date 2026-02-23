namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICommoRoseContextActionEntityData))]
public class UICommoRoseContextActionEntity : UICommoRoseActionEntity, IEntityData<FrostySdk.Ebx.UICommoRoseContextActionEntityData>
{
    public new FrostySdk.Ebx.UICommoRoseContextActionEntityData Data => data as FrostySdk.Ebx.UICommoRoseContextActionEntityData;
    public override string DisplayName => "UICommoRoseContextAction";

    public UICommoRoseContextActionEntity(FrostySdk.Ebx.UICommoRoseContextActionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

