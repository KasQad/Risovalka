using Types;

namespace Engines
{
	public interface IEngine
	{
		public bool IsStarted { get; }
		public float Power { get; }

		public float FuelConsumption { get; }

		public FuelType FuelType { get; }

		public void Start();
		public void Stop();
	}
}
