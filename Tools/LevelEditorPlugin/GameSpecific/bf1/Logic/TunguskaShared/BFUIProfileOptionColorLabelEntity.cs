namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIProfileOptionColorLabelEntityData))]
public class BFUIProfileOptionColorLabelEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIProfileOptionColorLabelEntityData>
{
    public new FrostySdk.Ebx.BFUIProfileOptionColorLabelEntityData Data => data as FrostySdk.Ebx.BFUIProfileOptionColorLabelEntityData;
    public override string DisplayName => "BFUIProfileOptionColorLabel";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIProfileOptionColorLabelEntity(FrostySdk.Ebx.BFUIProfileOptionColorLabelEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

