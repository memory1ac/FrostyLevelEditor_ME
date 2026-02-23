namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ChrCharEntityData))]
public class ChrCharEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ChrCharEntityData>
{
    public new FrostySdk.Ebx.ChrCharEntityData Data => data as FrostySdk.Ebx.ChrCharEntityData;
    public override string DisplayName => "ChrChar";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public ChrCharEntity(FrostySdk.Ebx.ChrCharEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

