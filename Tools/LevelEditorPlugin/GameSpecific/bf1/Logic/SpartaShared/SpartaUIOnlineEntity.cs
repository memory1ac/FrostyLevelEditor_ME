namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpartaUIOnlineEntityData))]
public class SpartaUIOnlineEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SpartaUIOnlineEntityData>
{
    public new FrostySdk.Ebx.SpartaUIOnlineEntityData Data => data as FrostySdk.Ebx.SpartaUIOnlineEntityData;
    public override string DisplayName => "SpartaUIOnline";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public SpartaUIOnlineEntity(FrostySdk.Ebx.SpartaUIOnlineEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

