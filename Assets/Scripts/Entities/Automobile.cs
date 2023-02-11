namespace Entities
{
	public class Automobile : BaseEntity
	{
		private float _movingSpeed;

		internal float MovingSpeed
		{
			get => _movingSpeed;
			set => _movingSpeed = value;
		}
		
	}
}
