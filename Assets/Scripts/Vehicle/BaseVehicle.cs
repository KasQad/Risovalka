using Engines;
using UnityEngine;

namespace Vehicle
{
	public abstract class BaseVehicle : IVehicle
	{
		public IEngine Engine { get; }

		protected internal BaseVehicle(IEngine engine)
		{
			Engine = engine;
		}

		public virtual void Move()
		{
			if (Engine == null)
			{
				Debug.Log($"Engine not found");
				return;
			}

			if (Engine.IsStarted)
				Debug.Log($"BaseVehicle move");
			else
				Debug.Log($"BaseVehicle cannot move because the engine is not running");
		}
	}
}
