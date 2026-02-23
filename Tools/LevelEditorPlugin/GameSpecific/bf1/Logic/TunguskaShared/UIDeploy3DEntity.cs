namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIDeploy3DEntityData))]
public class UIDeploy3DEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIDeploy3DEntityData>
{
    public new FrostySdk.Ebx.UIDeploy3DEntityData Data => data as FrostySdk.Ebx.UIDeploy3DEntityData;
    public override string DisplayName => "UIDeploy3D";

    public UIDeploy3DEntity(FrostySdk.Ebx.UIDeploy3DEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

