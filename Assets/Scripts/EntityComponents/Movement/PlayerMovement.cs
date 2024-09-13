using Assets.Scripts.EntityComponents.Movement;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Assets.Scripts.EntityComponents
{
	public class PlayerMovement : IMovement
	{
		public Transform Transform { get; set; }

		public UnityEvent MoveEvent { get; } = new();

		private InputActions input;

		public PlayerMovement(InputActions input)
		{
			this.input = input;
			Debug.Log("PlayerMovement ctor " + input);
			input.Gameplay.MoveDown.performed += context => Move(new Vector2(0, -1));
			input.Gameplay.MoveUp.performed += context => Move(new Vector2(0, 1));
			input.Gameplay.MoveLeft.performed += context => Move(new Vector2(-1, 0));
			input.Gameplay.MoveRight.performed += context => Move(new Vector2(1, 0));
			input.Enable();
		}

		void Move(Vector2 dir)
		{
			Debug.Log("Move: " + dir);
			Transform.position += new Vector3(dir.x, 0f, dir.y);
		}
	}
}
