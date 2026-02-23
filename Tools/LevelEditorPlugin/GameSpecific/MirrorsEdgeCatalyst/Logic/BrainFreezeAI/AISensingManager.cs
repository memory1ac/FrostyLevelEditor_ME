using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AISensingManagerData))]
	public class AISensingManager : AIManagerBase, IEntityData<FrostySdk.Ebx.AISensingManagerData>
	{
		public new FrostySdk.Ebx.AISensingManagerData Data => data as FrostySdk.Ebx.AISensingManagerData;
		public override string DisplayName => "AISensingManager";

		public AISensingManager(FrostySdk.Ebx.AISensingManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

