using System.Collections.Generic;
using Entities;
using Types;
using UnityEngine;

public class Draw : MonoBehaviour
{
	[SerializeField] private Car _prefabCar;
	[SerializeField] private Circle _prefabCircle;
	[SerializeField] private Wheel _prefabWheel;

	private readonly Dictionary<DrawTypes, BaseEntity> _entities = new Dictionary<DrawTypes, BaseEntity>();

	private void Awake()
	{
		_entities.Add(DrawTypes.Car, _prefabCar);
		_entities.Add(DrawTypes.Circle, _prefabCircle);
		_entities.Add(DrawTypes.Wheel, _prefabWheel);

		DrawEntity(DrawTypes.Circle);
	}

	private void DrawEntity(DrawTypes drawType)
	{
		if (!_entities.TryGetValue(drawType, out var prefabEntity)) return;

		Instantiate(prefabEntity, transform);
	}
}
