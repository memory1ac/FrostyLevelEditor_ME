namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DVRMomentsEntityData))]
public class DVRMomentsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DVRMomentsEntityData>
{
    public new FrostySdk.Ebx.DVRMomentsEntityData Data => data as FrostySdk.Ebx.DVRMomentsEntityData;
    public override string DisplayName => "DVRMoments";

    public DVRMomentsEntity(FrostySdk.Ebx.DVRMomentsEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

