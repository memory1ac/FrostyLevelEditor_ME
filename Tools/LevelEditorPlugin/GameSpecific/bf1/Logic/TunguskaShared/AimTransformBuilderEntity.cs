namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.AimTransformBuilderEntityData))]
public class AimTransformBuilderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AimTransformBuilderEntityData>
{
    public new FrostySdk.Ebx.AimTransformBuilderEntityData Data => data as FrostySdk.Ebx.AimTransformBuilderEntityData;
    public override string DisplayName => "AimTransformBuilder";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public AimTransformBuilderEntity(FrostySdk.Ebx.AimTransformBuilderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

