namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISingleplayerDebugMenuProviderEntityData))]
public class UISingleplayerDebugMenuProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UISingleplayerDebugMenuProviderEntityData>
{
    public new FrostySdk.Ebx.UISingleplayerDebugMenuProviderEntityData Data => data as FrostySdk.Ebx.UISingleplayerDebugMenuProviderEntityData;
    public override string DisplayName => "UISingleplayerDebugMenuProvider";

    public UISingleplayerDebugMenuProviderEntity(FrostySdk.Ebx.UISingleplayerDebugMenuProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

