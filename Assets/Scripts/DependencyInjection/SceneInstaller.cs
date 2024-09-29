using Assets.Scripts.EntityComponents;
using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
	[SerializeField]
	private Player playerPrefab;
	[SerializeField]
	private Transform playerSpawnPoint;

	public override void InstallBindings()
    {
        Container.Bind<InputActions>().AsSingle();
        Container.BindInterfacesAndSelfTo<PlayerMovement>().AsSingle();

		var player = Container.InstantiatePrefabForComponent<Player>(playerPrefab, playerSpawnPoint.position, playerSpawnPoint.rotation, null);
        Container.Bind<Player>().FromInstance(player).AsSingle();
    }
}