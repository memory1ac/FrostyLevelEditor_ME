namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSpartaFrontEndEntityData))]
public class BFSpartaFrontEndEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFSpartaFrontEndEntityData>
{
    public new FrostySdk.Ebx.BFSpartaFrontEndEntityData Data => data as FrostySdk.Ebx.BFSpartaFrontEndEntityData;
    public override string DisplayName => "BFSpartaFrontEnd";

    public BFSpartaFrontEndEntity(FrostySdk.Ebx.BFSpartaFrontEndEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

