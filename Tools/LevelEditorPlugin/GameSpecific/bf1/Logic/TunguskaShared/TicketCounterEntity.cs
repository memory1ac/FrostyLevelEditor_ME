namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TicketCounterEntityData))]
public class TicketCounterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TicketCounterEntityData>
{
    public new FrostySdk.Ebx.TicketCounterEntityData Data => data as FrostySdk.Ebx.TicketCounterEntityData;
    public override string DisplayName => "TicketCounter";

    public TicketCounterEntity(FrostySdk.Ebx.TicketCounterEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

