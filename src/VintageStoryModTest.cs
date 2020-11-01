using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace VintageStoryMods
{
	public class VintageStoryModTest : ModSystem
	{
		public override void Start(ICoreAPI api)
		{
			api.RegisterBlockBehaviorClass(InstaTNTBehavior.NAME, typeof(InstaTNTBehavior));
		}
		
		public override void StartClientSide(ICoreClientAPI api)
		{
			
		}
		
		public override void StartServerSide(ICoreServerAPI api)
		{
			
		}
	}
}