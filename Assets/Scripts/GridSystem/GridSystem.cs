using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject cellPrefab;

	[SerializeField]
	private int gridWidth = 10;
	[SerializeField]
	private int gridHeight = 10;

    private GridCell[,] gridCells;

	private void Awake()
	{
		gridCells = new GridCell[gridWidth, gridHeight];
		for (int x = 0; x < gridWidth; x++)
			for (int y = 0; y < gridHeight; y++)
			{
				gridCells[x, y] = Instantiate(cellPrefab, new Vector3(x, 0, y), Quaternion.identity, this.transform).GetComponent<GridCell>();
			}
		
	}
}
