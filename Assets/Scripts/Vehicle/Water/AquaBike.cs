using Engines;
using UnityEngine;

namespace Vehicle.Water
{
	public class AquaBike : BaseVehicle
	{
		protected internal AquaBike(IEngine engine) : base(engine)
		{
		}
		
		public override void Move()
		{
			if (Engine == null)
			{
				Debug.Log($"AquaBike not found");
				return;
			}

			if (Engine.IsStarted)
				Debug.Log($"AquaBike move");
			else
				Debug.Log($"AquaBike cannot move because the engine is not running");
		}
	}
	
}
