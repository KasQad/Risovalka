using System.Collections.Generic;
using Types;
using Vehicle;

namespace Factories
{
	public abstract class BaseVehicleFactory : IVehicleFactory
	{
		private readonly Dictionary<VehicleType, IVehicle> _vehicles = new Dictionary<VehicleType, IVehicle>();

		protected internal void AddAvailableVehicle(VehicleType vehicleType, IVehicle iVehicle)
		{
			if (_vehicles.ContainsKey(vehicleType)) return;

			_vehicles.Add(vehicleType, iVehicle);
		}

		public IVehicle CreateVehicle(VehicleType vehicleType)
		{
			if (!_vehicles.TryGetValue(vehicleType, out var vehicle)) return null;
			return vehicle;
		}
	}
}
