using System;

using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace CarlynBlocks
{
	public class CarlynBlocksMod : ModSystem
	{
		public override void Start(ICoreAPI api)
		{
			Console.WriteLine("Mod Loaded!");
			//api.RegisterBlockBehaviorClass(GoldBlockBehavior.NAME, typeof(GoldBlockBehavior));
		}
		
		public override void StartClientSide(ICoreClientAPI api)
		{
			
		}
		
		public override void StartServerSide(ICoreServerAPI api)
		{
			
		}
	}
}