namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILoadoutWriterEntityData))]
public class BFUILoadoutWriterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUILoadoutWriterEntityData>
{
    public new FrostySdk.Ebx.BFUILoadoutWriterEntityData Data => data as FrostySdk.Ebx.BFUILoadoutWriterEntityData;
    public override string DisplayName => "BFUILoadoutWriter";

    public BFUILoadoutWriterEntity(FrostySdk.Ebx.BFUILoadoutWriterEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

