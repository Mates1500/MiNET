﻿using MiNET.Items;
using MiNET.Worlds;

namespace MiNET.Entities.Passive
{
	public class MushroomCow : PassiveMob
	{
		public MushroomCow(Level level) : base((int) EntityType.MushroomCow, level)
		{
			Width = Length = 0.9;
			Height = 1.4;
		}

		public override Item[] GetDrops()
		{
			return new[]
			{
				ItemFactory.GetItem(40, 0, 2),
				ItemFactory.GetItem(334, 0, 1)
			};
		}
	}
}