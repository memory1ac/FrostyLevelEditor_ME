namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.IsSavingEntityData))]
public class IsSavingEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IsSavingEntityData>
{
    public new FrostySdk.Ebx.IsSavingEntityData Data => data as FrostySdk.Ebx.IsSavingEntityData;
    public override string DisplayName => "IsSaving";

    public IsSavingEntity(FrostySdk.Ebx.IsSavingEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

