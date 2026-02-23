namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIFloatThrottleEntityData))]
public class UIFloatThrottleEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIFloatThrottleEntityData>
{
    public new FrostySdk.Ebx.UIFloatThrottleEntityData Data => data as FrostySdk.Ebx.UIFloatThrottleEntityData;
    public override string DisplayName => "UIFloatThrottle";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIFloatThrottleEntity(FrostySdk.Ebx.UIFloatThrottleEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

