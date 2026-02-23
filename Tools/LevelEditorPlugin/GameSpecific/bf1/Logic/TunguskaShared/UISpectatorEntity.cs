namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISpectatorEntityData))]
public class UISpectatorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UISpectatorEntityData>
{
    public new FrostySdk.Ebx.UISpectatorEntityData Data => data as FrostySdk.Ebx.UISpectatorEntityData;
    public override string DisplayName => "UISpectator";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UISpectatorEntity(FrostySdk.Ebx.UISpectatorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

