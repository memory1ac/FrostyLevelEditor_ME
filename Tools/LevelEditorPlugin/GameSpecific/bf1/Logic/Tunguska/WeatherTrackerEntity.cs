namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.WeatherTrackerEntityData))]
public class WeatherTrackerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.WeatherTrackerEntityData>
{
    public new FrostySdk.Ebx.WeatherTrackerEntityData Data => data as FrostySdk.Ebx.WeatherTrackerEntityData;
    public override string DisplayName => "WeatherTracker";

    public WeatherTrackerEntity(FrostySdk.Ebx.WeatherTrackerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

