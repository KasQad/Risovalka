namespace Entities
{
	public class Wheel : BaseEntity
	{
		internal readonly float Diameter;

		protected Wheel(float diameter)
		{
			Diameter = diameter;
		}
	}
}
