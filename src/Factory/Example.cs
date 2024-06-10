namespace DesignPatterns.Factory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PizzaStoreFactory
    {
        public PizzaStore Create(string location)
        {
            switch (location)
            {
                case "Valencia":
                    return new ValenciaPizzaStore();
                case "StGallen":
                    return new StGallenPizzaStore();
                case "Wiener":
                    return new WienerPizzaStore();
                default:
                    throw new InvalidEnumArgumentException();
            }
        }
    }

    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza();

        public abstract Dürüm CreateDürüm(); 


        protected Pizza CreateBasePizza()
        {
            var pizza = new Pizza();
            return pizza;
        }
    }

    public abstract class Dürüm
    {
    }

    public class ValenciaPizzaStore : PizzaStore
    {
        public override Pizza Create()
        {
            var pizza = CreateBasePizza();
            pizza.AddTopping("Paella");
            return pizza;
        }
    }

    public class StGallenPizzaStore : PizzaStore
    {
        public override Pizza Create()
        {
            var pizza = CreateBasePizza();
            pizza.AddTopping("Bratwurst");
            return pizza;
        }
    }

    public class WienerPizzaStore : PizzaStore
    {

        public override Pizza Create()
        {
            var pizza = CreateBasePizza();
            pizza.AddTopping("Schnitzel");
            return pizza;
        }
    }


}
