using Types;
using Vehicle;

namespace Factories
{
	public interface IVehicleFactory
	{
		public IVehicle CreateVehicle(VehicleType vehicleType );
	}
}
