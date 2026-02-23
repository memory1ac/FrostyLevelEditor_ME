namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FloatEaseFunctionEntityData))]
public class FloatEaseFunctionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FloatEaseFunctionEntityData>
{
    public new FrostySdk.Ebx.FloatEaseFunctionEntityData Data => data as FrostySdk.Ebx.FloatEaseFunctionEntityData;
    public override string DisplayName => "FloatEaseFunction";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public FloatEaseFunctionEntity(FrostySdk.Ebx.FloatEaseFunctionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

