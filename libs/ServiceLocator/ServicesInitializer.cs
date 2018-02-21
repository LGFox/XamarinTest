using System;
using Interfaces.Services;
using Prism.Ioc;
using Services.Services;

namespace ServiceLocator
{
    public static class ServicesInitializer
    {
        public static void Initialize(IContainerRegistry containerRegistry, IContainerProvider containerProvider)
        {
            containerRegistry.RegisterSingleton<ICalculatorService, CalculatorService>();
        }
    }
}
