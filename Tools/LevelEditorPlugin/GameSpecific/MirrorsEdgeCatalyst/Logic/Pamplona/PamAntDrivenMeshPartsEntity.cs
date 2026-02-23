using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAntDrivenMeshPartsEntityData))]
	public class PamAntDrivenMeshPartsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamAntDrivenMeshPartsEntityData>
	{
		public new FrostySdk.Ebx.PamAntDrivenMeshPartsEntityData Data => data as FrostySdk.Ebx.PamAntDrivenMeshPartsEntityData;
		public override string DisplayName => "PamAntDrivenMeshParts";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamAntDrivenMeshPartsEntity(FrostySdk.Ebx.PamAntDrivenMeshPartsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

