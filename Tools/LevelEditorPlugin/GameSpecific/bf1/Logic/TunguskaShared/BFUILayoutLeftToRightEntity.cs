namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILayoutLeftToRightEntityData))]
public class BFUILayoutLeftToRightEntity : BFUILayoutEntity, IEntityData<FrostySdk.Ebx.BFUILayoutLeftToRightEntityData>
{
    public new FrostySdk.Ebx.BFUILayoutLeftToRightEntityData Data => data as FrostySdk.Ebx.BFUILayoutLeftToRightEntityData;
    public override string DisplayName => "BFUILayoutLeftToRight";

    public BFUILayoutLeftToRightEntity(FrostySdk.Ebx.BFUILayoutLeftToRightEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

