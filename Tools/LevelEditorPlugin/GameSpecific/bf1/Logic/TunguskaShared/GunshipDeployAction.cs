namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.GunshipDeployActionData))]
public class GunshipDeployAction : CommanderActionBase, IEntityData<FrostySdk.Ebx.GunshipDeployActionData>
{
    public new FrostySdk.Ebx.GunshipDeployActionData Data => data as FrostySdk.Ebx.GunshipDeployActionData;
    public override string DisplayName => "GunshipDeployAction";

    public GunshipDeployAction(FrostySdk.Ebx.GunshipDeployActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

