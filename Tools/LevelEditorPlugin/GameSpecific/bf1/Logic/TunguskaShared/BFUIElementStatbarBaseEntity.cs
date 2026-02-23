namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementStatbarBaseEntityData))]
public class BFUIElementStatbarBaseEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementStatbarBaseEntityData>
{
    public new FrostySdk.Ebx.BFUIElementStatbarBaseEntityData Data => data as FrostySdk.Ebx.BFUIElementStatbarBaseEntityData;
    public override string DisplayName => "BFUIElementStatbarBase";

    public BFUIElementStatbarBaseEntity(FrostySdk.Ebx.BFUIElementStatbarBaseEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

