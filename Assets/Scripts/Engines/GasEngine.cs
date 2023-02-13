using Types;

namespace Engines
{
	public class GasEngine : BaseEngine
	{
		protected internal GasEngine(FuelType fuelType, float power, float fuelConsumption ) : base(fuelType, power , fuelConsumption)
		{
		}
	}
}
