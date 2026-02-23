namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIColorPresetsEntityData))]
public class BFUIColorPresetsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIColorPresetsEntityData>
{
    public new FrostySdk.Ebx.BFUIColorPresetsEntityData Data => data as FrostySdk.Ebx.BFUIColorPresetsEntityData;
    public override string DisplayName => "BFUIColorPresets";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIColorPresetsEntity(FrostySdk.Ebx.BFUIColorPresetsEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

