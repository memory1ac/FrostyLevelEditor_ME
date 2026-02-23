namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICommoRoseActionDataProviderEntityData))]
public class UICommoRoseActionDataProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UICommoRoseActionDataProviderEntityData>
{
    public new FrostySdk.Ebx.UICommoRoseActionDataProviderEntityData Data => data as FrostySdk.Ebx.UICommoRoseActionDataProviderEntityData;
    public override string DisplayName => "UICommoRoseActionDataProvider";

    public UICommoRoseActionDataProviderEntity(FrostySdk.Ebx.UICommoRoseActionDataProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

