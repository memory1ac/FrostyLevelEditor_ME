namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIObjectivesDataProviderEntityData))]
public class UIObjectivesDataProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIObjectivesDataProviderEntityData>
{
    public new FrostySdk.Ebx.UIObjectivesDataProviderEntityData Data => data as FrostySdk.Ebx.UIObjectivesDataProviderEntityData;
    public override string DisplayName => "UIObjectivesDataProvider";

    public UIObjectivesDataProviderEntity(FrostySdk.Ebx.UIObjectivesDataProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

