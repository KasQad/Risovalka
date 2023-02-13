using Types;

namespace Engines
{
	public class DieselEngine : Engine
	{
		protected internal DieselEngine(FuelType fuelType, float power, float fuelConsumption ) : base(fuelType, power , fuelConsumption)
		{
		}
	}
}
