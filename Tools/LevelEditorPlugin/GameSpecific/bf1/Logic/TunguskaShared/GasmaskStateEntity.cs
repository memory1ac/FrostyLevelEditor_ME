namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.GasmaskStateEntityData))]
public class GasmaskStateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.GasmaskStateEntityData>
{
    public new FrostySdk.Ebx.GasmaskStateEntityData Data => data as FrostySdk.Ebx.GasmaskStateEntityData;
    public override string DisplayName => "GasmaskState";

    public GasmaskStateEntity(FrostySdk.Ebx.GasmaskStateEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

