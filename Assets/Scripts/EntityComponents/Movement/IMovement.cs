using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.EntityComponents.Movement
{
	public interface IMovement
	{
		Transform Transform { get; }

		UnityEvent MoveEvent { get; }
	}
}
