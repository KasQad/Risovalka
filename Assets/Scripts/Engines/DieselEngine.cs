using Types;

namespace Engines
{
	public class DieselEngine : BaseEngine
	{
		protected internal DieselEngine(FuelType fuelType, float power, float fuelConsumption ) : base(fuelType, power , fuelConsumption)
		{
		}
	}
}
