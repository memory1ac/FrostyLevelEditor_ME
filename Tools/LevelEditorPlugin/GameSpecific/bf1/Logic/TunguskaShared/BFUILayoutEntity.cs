namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILayoutEntityData))]
public class BFUILayoutEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUILayoutEntityData>
{
    public new FrostySdk.Ebx.BFUILayoutEntityData Data => data as FrostySdk.Ebx.BFUILayoutEntityData;
    public override string DisplayName => "BFUILayout";

    public BFUILayoutEntity(FrostySdk.Ebx.BFUILayoutEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

