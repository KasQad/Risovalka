using Engines;
using Factories;
using Types;
using UnityEngine;
using Vehicle.Land;
using Vehicle.Water;

namespace Builder
{
	public class Builder : MonoBehaviour
	{
		private readonly WaterVehicleFactory _waterVehicleFactory = new WaterVehicleFactory();
		private readonly LandVehicleFactory _landVehicleFactory = new LandVehicleFactory();

		private void Awake()
		{
			DieselEngine dieselEngine = new DieselEngine(FuelType.Diesel, 100f, 1f);
			GasEngine gasEngine = new GasEngine(FuelType.Gas, 80f, 0.8f);

			_waterVehicleFactory.AddAvailableVehicle(VehicleType.AquaBike, new AquaBike(gasEngine));
			_waterVehicleFactory.AddAvailableVehicle(VehicleType.SteamShip, new SteamShip(dieselEngine));

			_landVehicleFactory.AddAvailableVehicle(VehicleType.Car, new Car(dieselEngine));
			_landVehicleFactory.AddAvailableVehicle(VehicleType.Bicycle, new Bicycle(gasEngine));
			_landVehicleFactory.AddAvailableVehicle(VehicleType.QuadBike, new QuadBike(gasEngine));

			var aquaBike = _waterVehicleFactory.CreateVehicle(VehicleType.AquaBike);
			aquaBike.Engine.Start();
			aquaBike.Move();

			var car = _landVehicleFactory.CreateVehicle(VehicleType.Car);
			car.Move();
		}
	}
}
