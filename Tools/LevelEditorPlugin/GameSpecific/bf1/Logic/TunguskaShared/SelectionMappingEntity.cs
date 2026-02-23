namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SelectionMappingEntityData))]
public class SelectionMappingEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SelectionMappingEntityData>
{
    public new FrostySdk.Ebx.SelectionMappingEntityData Data => data as FrostySdk.Ebx.SelectionMappingEntityData;
    public override string DisplayName => "SelectionMapping";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public SelectionMappingEntity(FrostySdk.Ebx.SelectionMappingEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

