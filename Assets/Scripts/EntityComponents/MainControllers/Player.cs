using Assets.Scripts.EntityComponents;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Player : MonoBehaviour
{
    PlayerMovement movement;

    [Inject]
    private void Construct(PlayerMovement movement)
    {
        Debug.Log("Construct");
        this.movement = movement;
        movement.Transform = transform;
    }
}
