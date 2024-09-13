using Assets.Scripts.EntityComponents;
using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    [SerializeField] private GameObject player;

    public override void InstallBindings()
    {
        Container.Bind<InputActions>().AsSingle();
        Container.Bind<PlayerMovement>().AsSingle();
        Container.Bind<Player>().FromComponentOn(player).AsSingle();
    }
}