namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.LocalizedStringEntityBaseData))]
public class LocalizedStringEntityBase : LogicEntity, IEntityData<FrostySdk.Ebx.LocalizedStringEntityBaseData>
{
    public new FrostySdk.Ebx.LocalizedStringEntityBaseData Data => data as FrostySdk.Ebx.LocalizedStringEntityBaseData;
    public override string DisplayName => "LocalizedStringEntityBase";

    public LocalizedStringEntityBase(FrostySdk.Ebx.LocalizedStringEntityBaseData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

