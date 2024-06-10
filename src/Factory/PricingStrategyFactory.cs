namespace DesignPatterns.Factory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using DesignPatterns.Decorator;
    using DesignPatterns.Strategy;

    public class PricingStrategyFactory
    {
        private static readonly Dictionary<Type, ISalePricingStrategy> s_salePricingStrategies = [];

        public static ISalePricingStrategy Create(string strategyName, params object[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var pricingStrategies = assembly.GetTypes()
                .Where(x => !x.IsAbstract)
                .Where(x => !x.IsInterface)
                .Where(x => x.IsAssignableTo(typeof(ISalePricingStrategy)))
                .Where(x => !x.Name.Contains("Decorator"));

            var pricingStrategyType = pricingStrategies.FirstOrDefault(x => x.Name.StartsWith(strategyName));

            if (s_salePricingStrategies.ContainsKey(pricingStrategyType))
            {
                return s_salePricingStrategies[pricingStrategyType];
            }

            var singletonAttribute = pricingStrategyType.GetCustomAttribute<SingletonAttribute>();
            var pricingStrategy = (ISalePricingStrategy)Activator.CreateInstance(pricingStrategyType, args);
            if (singletonAttribute is not null)
            {
                s_salePricingStrategies.Add(pricingStrategyType, pricingStrategy);
            }

            return new TimingDecorator(pricingStrategy);
        }
    }
}
