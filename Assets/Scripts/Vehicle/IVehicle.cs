using Engines;

namespace Vehicle
{
	public interface IVehicle
	{
		public IEngine Engine { get; }
		public void Move();
	}
}
