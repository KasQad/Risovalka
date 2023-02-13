using Types;

namespace Engines
{
	public abstract class Engine : IEngine
	{
		private bool _isStarted;
		private readonly float _power;
		private readonly FuelType _fuelType;
		private readonly float _fuelConsumption;

		public bool IsStarted => _isStarted;

		public float Power => _power;

		public float FuelConsumption => _fuelConsumption;

		public FuelType FuelType => _fuelType;

		protected internal Engine(FuelType fuelType, float power, float fuelConsumption)
		{
			_power = power;
			_fuelConsumption = fuelConsumption;
			_fuelType = fuelType;
		}

		public void Start()
		{
			_isStarted = true;
		}

		public void Stop()
		{
			_isStarted = false;
		}
	}
}
