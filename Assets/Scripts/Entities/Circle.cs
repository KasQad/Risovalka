using Entities.Interfaces;
using UnityEngine;

namespace Entities
{
	public class Circle : GeometricFigure, IArea
	{
		private readonly float _radius;

		protected Circle(float radius)
		{
			_radius = radius;
		}

		public float CalcArea()
		{
			return Mathf.PI * Mathf.Pow(_radius, 2);
		}
	}
}
