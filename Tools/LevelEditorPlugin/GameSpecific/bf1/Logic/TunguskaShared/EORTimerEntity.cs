namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.EORTimerEntityData))]
public class EORTimerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.EORTimerEntityData>
{
    public new FrostySdk.Ebx.EORTimerEntityData Data => data as FrostySdk.Ebx.EORTimerEntityData;
    public override string DisplayName => "EORTimer";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public EORTimerEntity(FrostySdk.Ebx.EORTimerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

