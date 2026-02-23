namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIProfileOptionResolutionEntityData))]
public class BFUIProfileOptionResolutionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIProfileOptionResolutionEntityData>
{
    public new FrostySdk.Ebx.BFUIProfileOptionResolutionEntityData Data => data as FrostySdk.Ebx.BFUIProfileOptionResolutionEntityData;
    public override string DisplayName => "BFUIProfileOptionResolution";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIProfileOptionResolutionEntity(FrostySdk.Ebx.BFUIProfileOptionResolutionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

