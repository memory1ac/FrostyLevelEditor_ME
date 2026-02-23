namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FriendlyFireEntityData))]
public class FriendlyFireEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FriendlyFireEntityData>
{
    public new FrostySdk.Ebx.FriendlyFireEntityData Data => data as FrostySdk.Ebx.FriendlyFireEntityData;
    public override string DisplayName => "FriendlyFire";

    public FriendlyFireEntity(FrostySdk.Ebx.FriendlyFireEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

