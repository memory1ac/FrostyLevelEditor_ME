namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PerfHudDisplayStringEntityData))]
public class PerfHudDisplayStringEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PerfHudDisplayStringEntityData>
{
    public new FrostySdk.Ebx.PerfHudDisplayStringEntityData Data => data as FrostySdk.Ebx.PerfHudDisplayStringEntityData;
    public override string DisplayName => "PerfHudDisplayString";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public PerfHudDisplayStringEntity(FrostySdk.Ebx.PerfHudDisplayStringEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

