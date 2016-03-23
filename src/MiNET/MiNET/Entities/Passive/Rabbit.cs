﻿using MiNET.Items;
using MiNET.Worlds;

namespace MiNET.Entities.Passive
{
	public class Rabbit : PassiveMob
	{
		public Rabbit(Level level) : base((int) EntityType.Rabbit, level)
		{
			Width = Length = 0.6;
			Height = 0.7;
		}

		public override Item[] GetDrops()
		{
			return new []
			{
				ItemFactory.GetItem(411)
			};
		}
	}
}