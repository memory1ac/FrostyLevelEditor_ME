namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.MapNavigationOverrideEntityData))]
public class MapNavigationOverrideEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MapNavigationOverrideEntityData>
{
    public new FrostySdk.Ebx.MapNavigationOverrideEntityData Data => data as FrostySdk.Ebx.MapNavigationOverrideEntityData;
    public override string DisplayName => "MapNavigationOverride";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public MapNavigationOverrideEntity(FrostySdk.Ebx.MapNavigationOverrideEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

