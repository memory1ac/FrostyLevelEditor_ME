namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICommoRoseRequestsEntityData))]
public class UICommoRoseRequestsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UICommoRoseRequestsEntityData>
{
    public new FrostySdk.Ebx.UICommoRoseRequestsEntityData Data => data as FrostySdk.Ebx.UICommoRoseRequestsEntityData;
    public override string DisplayName => "UICommoRoseRequests";

    public UICommoRoseRequestsEntity(FrostySdk.Ebx.UICommoRoseRequestsEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

