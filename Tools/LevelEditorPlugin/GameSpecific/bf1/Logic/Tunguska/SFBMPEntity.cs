namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SFBMPEntityData))]
public class SFBMPEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SFBMPEntityData>
{
    public new FrostySdk.Ebx.SFBMPEntityData Data => data as FrostySdk.Ebx.SFBMPEntityData;
    public override string DisplayName => "SFBMP";

    public SFBMPEntity(FrostySdk.Ebx.SFBMPEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

