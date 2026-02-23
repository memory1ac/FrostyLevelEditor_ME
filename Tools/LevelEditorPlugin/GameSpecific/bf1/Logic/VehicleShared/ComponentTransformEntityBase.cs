namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ComponentTransformEntityBaseData))]
public class ComponentTransformEntityBase : LogicEntity, IEntityData<FrostySdk.Ebx.ComponentTransformEntityBaseData>
{
    public new FrostySdk.Ebx.ComponentTransformEntityBaseData Data => data as FrostySdk.Ebx.ComponentTransformEntityBaseData;
    public override string DisplayName => "ComponentTransformEntityBase";

    public ComponentTransformEntityBase(FrostySdk.Ebx.ComponentTransformEntityBaseData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

