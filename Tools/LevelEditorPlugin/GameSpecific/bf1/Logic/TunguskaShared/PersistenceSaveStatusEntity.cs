namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PersistenceSaveStatusEntityData))]
public class PersistenceSaveStatusEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PersistenceSaveStatusEntityData>
{
    public new FrostySdk.Ebx.PersistenceSaveStatusEntityData Data => data as FrostySdk.Ebx.PersistenceSaveStatusEntityData;
    public override string DisplayName => "PersistenceSaveStatus";

    public PersistenceSaveStatusEntity(FrostySdk.Ebx.PersistenceSaveStatusEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

