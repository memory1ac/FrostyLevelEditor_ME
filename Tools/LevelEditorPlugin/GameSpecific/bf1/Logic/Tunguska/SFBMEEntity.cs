namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SFBMEEntityData))]
public class SFBMEEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SFBMEEntityData>
{
    public new FrostySdk.Ebx.SFBMEEntityData Data => data as FrostySdk.Ebx.SFBMEEntityData;
    public override string DisplayName => "SFBME";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public SFBMEEntity(FrostySdk.Ebx.SFBMEEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

