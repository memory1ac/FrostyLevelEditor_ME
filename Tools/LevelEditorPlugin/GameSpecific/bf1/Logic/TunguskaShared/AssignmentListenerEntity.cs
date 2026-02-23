namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.AssignmentListenerEntityData))]
public class AssignmentListenerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AssignmentListenerEntityData>
{
    public new FrostySdk.Ebx.AssignmentListenerEntityData Data => data as FrostySdk.Ebx.AssignmentListenerEntityData;
    public override string DisplayName => "AssignmentListener";

    public AssignmentListenerEntity(FrostySdk.Ebx.AssignmentListenerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

