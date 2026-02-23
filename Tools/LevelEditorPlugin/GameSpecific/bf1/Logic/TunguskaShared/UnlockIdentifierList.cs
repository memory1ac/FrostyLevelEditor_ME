namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UnlockIdentifierListData))]
public class UnlockIdentifierList : LogicEntity, IEntityData<FrostySdk.Ebx.UnlockIdentifierListData>
{
    public new FrostySdk.Ebx.UnlockIdentifierListData Data => data as FrostySdk.Ebx.UnlockIdentifierListData;
    public override string DisplayName => "UnlockIdentifierList";

    public UnlockIdentifierList(FrostySdk.Ebx.UnlockIdentifierListData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

