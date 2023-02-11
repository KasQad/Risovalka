using System.Collections.Generic;
using UnityEngine;

namespace Entities
{
	public class Car : Automobile
	{
		private readonly List<Wheel> _wheels = new List<Wheel>();

		protected Car(List<Wheel> wheels)
		{
			_wheels = new List<Wheel>(wheels);
		}

		internal void GetWheelsInfo()
		{
			var i = 1;
			foreach (var wheel in _wheels)
			{
				Debug.Log($"wheel #{i} Diameter: {wheel.Diameter}");
				i++;
			}
		}
	}
}
