using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
	public int Turn { get; private set; } = 0;

	public ObservableCollection<Unit> Units { get; private set; } = new ObservableCollection<Unit>();

	public IEnumerator<Unit> CurrentUnit { get; private set; }

	public TurnSystem()
	{

	}

	void RegisterUnits()
	{
		foreach (var unit in Units)
		{
			unit.DeathEvent.AddListener(Death);
		}
	}

	void GameLoop()
	{
		while (Units.Count > 0)
		{
			StartUnitTurn();
			EndUnitTurn();
		}
	}

	void StartUnitTurn()
	{
		CurrentUnit.Current.Turn();
	}

	void EndUnitTurn()
	{
		if (!CurrentUnit.MoveNext())
		{
			EndTurn();
			return;
		}
		++Turn;
	}

	void Death(Unit unit)
	{
		Units.Remove(unit);
	}

	void StartTurn()
	{

	}

	void EndTurn()
	{

		CurrentUnit.Reset();
		Turn = 1;

	}
}
