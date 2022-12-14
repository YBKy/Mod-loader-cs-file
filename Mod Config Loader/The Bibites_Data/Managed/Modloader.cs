using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using UnityEngine;

namespace SimulationScripts.BibiteScripts
{
	// Token: 0x020001C4 RID: 452
	public class Mods
	{
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000D62 RID: 3426
		// (set) Token: 0x06000D63 RID: 3427
		public static Mods.Configs Config { get; set; }

		// Token: 0x020001C5 RID: 453
		public class NodesPlus
		{
			// Token: 0x04000A7B RID: 2683
			public bool Active {gte;set;}
		}

		// Token: 0x020001C7 RID: 455
		public class YBKVisionReworkMod
		{
			// Token: 0x04000A7D RID: 2685
			public bool Active {get;set;}
		}

		// Token: 0x020001C9 RID: 457
		public class Configs
		{
			// Token: 0x17000174 RID: 372
			// (get) Token: 0x06000D68 RID: 3432
			// (set) Token: 0x06000D69 RID: 3433
			public Mods.NodesPlus Nodes_Plus { get; set; }

			// Token: 0x17000175 RID: 373
			// (get) Token: 0x06000D6A RID: 3434
			// (set) Token: 0x06000D6B RID: 3435
			public Mods.YBKVisionReworkMod YBK_Vision_ReworkMod { get; set; }

			// Token: 0x06000D77 RID: 3447
			public static void InitModConfig()
			{
				Mods.Config = JsonConvert.DeserializeObject<Mods.Configs>(File.ReadAllText(Application.dataPath + "/Mods/config.txt"));
			}
		}
	}
}
