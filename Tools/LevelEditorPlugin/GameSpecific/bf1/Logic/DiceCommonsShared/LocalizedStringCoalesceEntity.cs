namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.LocalizedStringCoalesceEntityData))]
public class LocalizedStringCoalesceEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LocalizedStringCoalesceEntityData>
{
    public new FrostySdk.Ebx.LocalizedStringCoalesceEntityData Data => data as FrostySdk.Ebx.LocalizedStringCoalesceEntityData;
    public override string DisplayName => "LocalizedStringCoalesce";

    public LocalizedStringCoalesceEntity(FrostySdk.Ebx.LocalizedStringCoalesceEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

