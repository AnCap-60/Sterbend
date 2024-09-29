using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
	private GameObject playerPrefab;
	[SerializeField]
	private Transform playerSpawnPoint;

	private void Awake()
	{
		Instantiate(playerPrefab, playerSpawnPoint.position, playerSpawnPoint.rotation);
	}
}
