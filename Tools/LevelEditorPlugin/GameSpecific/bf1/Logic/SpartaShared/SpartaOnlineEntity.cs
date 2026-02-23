namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpartaOnlineEntityData))]
public class SpartaOnlineEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SpartaOnlineEntityData>
{
    public new FrostySdk.Ebx.SpartaOnlineEntityData Data => data as FrostySdk.Ebx.SpartaOnlineEntityData;
    public override string DisplayName => "SpartaOnline";

    public SpartaOnlineEntity(FrostySdk.Ebx.SpartaOnlineEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

