using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCharacterProxyData))]
	public class PamCharacterProxy : CharacterProxy, IEntityData<FrostySdk.Ebx.PamCharacterProxyData>
	{
		public new FrostySdk.Ebx.PamCharacterProxyData Data => data as FrostySdk.Ebx.PamCharacterProxyData;

		public PamCharacterProxy(FrostySdk.Ebx.PamCharacterProxyData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

