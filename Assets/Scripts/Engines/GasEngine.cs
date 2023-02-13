using Types;

namespace Engines
{
	public class GasEngine : Engine
	{
		protected internal GasEngine(FuelType fuelType, float power, float fuelConsumption ) : base(fuelType, power , fuelConsumption)
		{
		}
	}
}
