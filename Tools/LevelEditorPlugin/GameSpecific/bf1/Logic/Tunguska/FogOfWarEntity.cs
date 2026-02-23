namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FogOfWarEntityData))]
public class FogOfWarEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FogOfWarEntityData>
{
    public new FrostySdk.Ebx.FogOfWarEntityData Data => data as FrostySdk.Ebx.FogOfWarEntityData;
    public override string DisplayName => "FogOfWar";

    public FogOfWarEntity(FrostySdk.Ebx.FogOfWarEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

