namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIObjectivesEntityData))]
public class UIObjectivesEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIObjectivesEntityData>
{
    public new FrostySdk.Ebx.UIObjectivesEntityData Data => data as FrostySdk.Ebx.UIObjectivesEntityData;
    public override string DisplayName => "UIObjectives";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIObjectivesEntity(FrostySdk.Ebx.UIObjectivesEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

