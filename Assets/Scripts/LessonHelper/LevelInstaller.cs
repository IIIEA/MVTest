// using Zenject;

namespace Code
{
    /*public sealed class LevelInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            var view = FindObjectOfType<CurrencyProvider>();
            MoneyBind(view.MoneyView);
            GemBind(view.GemView);
        }

        private void MoneyBind(CurrencyView viewMoneyView)
        {
            Container
                .Bind<MoneyStorage>()
                .AsSingle()
                .WithArguments(10L)
                .NonLazy();

            Container.BindInterfacesTo<MoneyPanelAdapter>().AsSingle().WithArguments(viewMoneyView).NonLazy();
        }

        private void GemBind(CurrencyView viewGemView)
        {
            Container
                .Bind<GemStorage>()
                .AsSingle()
                .WithArguments(10L)
                .NonLazy();

            Container.BindInterfacesTo<GemPanelAdapter>().AsSingle().WithArguments(viewGemView).NonLazy();
        }
    }*/
}
