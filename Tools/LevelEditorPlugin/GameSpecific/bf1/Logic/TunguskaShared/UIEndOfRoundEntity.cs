namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIEndOfRoundEntityData))]
public class UIEndOfRoundEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIEndOfRoundEntityData>
{
    public new FrostySdk.Ebx.UIEndOfRoundEntityData Data => data as FrostySdk.Ebx.UIEndOfRoundEntityData;
    public override string DisplayName => "UIEndOfRound";

    public UIEndOfRoundEntity(FrostySdk.Ebx.UIEndOfRoundEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

