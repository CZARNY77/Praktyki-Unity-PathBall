using UnityEngine;
using Zenject;

public class MInstaller : MonoInstaller
{
    [SerializeField] GameObject Ball;
    public override void InstallBindings()
    {
        //Container.BindInstance(Ball);
        Container.Bind<GameObject>().FromInstance(Ball);
        Container.BindInterfacesAndSelfTo<Path>().AsSingle().NonLazy();
        Container.BindInterfacesAndSelfTo<Ball>().AsSingle().NonLazy();
        Container.BindInterfacesAndSelfTo<PlayerController>().AsSingle().NonLazy();
    }
}