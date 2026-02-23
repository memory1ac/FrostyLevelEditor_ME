namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TrackPlayerQueryEntityData))]
public class TrackPlayerQueryEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TrackPlayerQueryEntityData>
{
    public new FrostySdk.Ebx.TrackPlayerQueryEntityData Data => data as FrostySdk.Ebx.TrackPlayerQueryEntityData;
    public override string DisplayName => "TrackPlayerQuery";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public TrackPlayerQueryEntity(FrostySdk.Ebx.TrackPlayerQueryEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

