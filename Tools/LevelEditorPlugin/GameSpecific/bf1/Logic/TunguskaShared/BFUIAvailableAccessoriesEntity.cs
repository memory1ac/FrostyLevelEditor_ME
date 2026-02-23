namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIAvailableAccessoriesEntityData))]
public class BFUIAvailableAccessoriesEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIAvailableAccessoriesEntityData>
{
    public new FrostySdk.Ebx.BFUIAvailableAccessoriesEntityData Data => data as FrostySdk.Ebx.BFUIAvailableAccessoriesEntityData;
    public override string DisplayName => "BFUIAvailableAccessories";

    public BFUIAvailableAccessoriesEntity(FrostySdk.Ebx.BFUIAvailableAccessoriesEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

