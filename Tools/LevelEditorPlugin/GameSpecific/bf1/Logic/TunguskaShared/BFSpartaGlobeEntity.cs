namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSpartaGlobeEntityData))]
public class BFSpartaGlobeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFSpartaGlobeEntityData>
{
    public new FrostySdk.Ebx.BFSpartaGlobeEntityData Data => data as FrostySdk.Ebx.BFSpartaGlobeEntityData;
    public override string DisplayName => "BFSpartaGlobe";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFSpartaGlobeEntity(FrostySdk.Ebx.BFSpartaGlobeEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

