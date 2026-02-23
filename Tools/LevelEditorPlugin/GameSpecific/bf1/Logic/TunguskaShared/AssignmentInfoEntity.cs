namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.AssignmentInfoEntityData))]
public class AssignmentInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AssignmentInfoEntityData>
{
    public new FrostySdk.Ebx.AssignmentInfoEntityData Data => data as FrostySdk.Ebx.AssignmentInfoEntityData;
    public override string DisplayName => "AssignmentInfo";

    public AssignmentInfoEntity(FrostySdk.Ebx.AssignmentInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

