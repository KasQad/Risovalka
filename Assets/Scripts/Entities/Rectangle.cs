using Entities.Interfaces;

namespace Entities
{
	public class Rectangle : GeometricFigure, IArea
	{
		private readonly float _width;
		private readonly float _height;

		protected Rectangle(float width, float height)
		{
			_width = width;
			_height = height;
		}

		public float CalcArea()
		{
			return _width * _height;
		}
	}
}
