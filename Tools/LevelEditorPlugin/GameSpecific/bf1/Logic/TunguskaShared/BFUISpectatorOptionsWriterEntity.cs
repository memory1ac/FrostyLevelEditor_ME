namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUISpectatorOptionsWriterEntityData))]
public class BFUISpectatorOptionsWriterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUISpectatorOptionsWriterEntityData>
{
    public new FrostySdk.Ebx.BFUISpectatorOptionsWriterEntityData Data => data as FrostySdk.Ebx.BFUISpectatorOptionsWriterEntityData;
    public override string DisplayName => "BFUISpectatorOptionsWriter";

    public BFUISpectatorOptionsWriterEntity(FrostySdk.Ebx.BFUISpectatorOptionsWriterEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

