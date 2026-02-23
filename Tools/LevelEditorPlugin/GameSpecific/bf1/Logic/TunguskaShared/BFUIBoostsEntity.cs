namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIBoostsEntityData))]
public class BFUIBoostsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIBoostsEntityData>
{
    public new FrostySdk.Ebx.BFUIBoostsEntityData Data => data as FrostySdk.Ebx.BFUIBoostsEntityData;
    public override string DisplayName => "BFUIBoosts";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIBoostsEntity(FrostySdk.Ebx.BFUIBoostsEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

