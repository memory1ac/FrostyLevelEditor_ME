namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIInteractionPromptDataProviderEntityData))]
public class BFUIInteractionPromptDataProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIInteractionPromptDataProviderEntityData>
{
    public new FrostySdk.Ebx.BFUIInteractionPromptDataProviderEntityData Data => data as FrostySdk.Ebx.BFUIInteractionPromptDataProviderEntityData;
    public override string DisplayName => "BFUIInteractionPromptDataProvider";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIInteractionPromptDataProviderEntity(FrostySdk.Ebx.BFUIInteractionPromptDataProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

