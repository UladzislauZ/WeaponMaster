using Zenject;

namespace WeaponMaster
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<Player>().AsSingle();
            Container.Bind<IInventoryController>().To<InventoryController>().AsSingle();
        }
    }
}