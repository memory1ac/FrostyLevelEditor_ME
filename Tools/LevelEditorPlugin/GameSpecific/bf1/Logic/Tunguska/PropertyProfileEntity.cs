namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PropertyProfileEntityData))]
public class PropertyProfileEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PropertyProfileEntityData>
{
    public new FrostySdk.Ebx.PropertyProfileEntityData Data => data as FrostySdk.Ebx.PropertyProfileEntityData;
    public override string DisplayName => "PropertyProfile";

    public PropertyProfileEntity(FrostySdk.Ebx.PropertyProfileEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

