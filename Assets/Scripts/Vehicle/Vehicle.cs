using Engines;
using UnityEngine;

namespace Vehicle
{
	public abstract class Vehicle : IVehicle
	{
		public IEngine Engine { get; }

		protected internal Vehicle(IEngine engine)
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
				Debug.Log($"Vehicle move");
			else
				Debug.Log($"Vehicle cannot move because the engine is not running");
		}
	}
}
