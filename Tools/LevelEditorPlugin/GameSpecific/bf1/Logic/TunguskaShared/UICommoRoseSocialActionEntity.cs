namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICommoRoseSocialActionEntityData))]
public class UICommoRoseSocialActionEntity : UICommoRoseActionEntity, IEntityData<FrostySdk.Ebx.UICommoRoseSocialActionEntityData>
{
    public new FrostySdk.Ebx.UICommoRoseSocialActionEntityData Data => data as FrostySdk.Ebx.UICommoRoseSocialActionEntityData;
    public override string DisplayName => "UICommoRoseSocialAction";

    public UICommoRoseSocialActionEntity(FrostySdk.Ebx.UICommoRoseSocialActionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

