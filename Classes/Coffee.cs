namespace DecoratorPatternEx.Classes
{
    public interface ICoffee
    {
        decimal Cost();
    }

    public class BasicCoffee : ICoffee
    {
        private readonly decimal _basePrice = 2.5M;

        public decimal Cost()
        {
            return _basePrice;
        }
    }

    public abstract class CoffeeDecorator : ICoffee
    {
        protected readonly ICoffee _coffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual decimal Cost()
        {
            return _coffee.Cost();
        }
    }

    public class MilkDecorator : CoffeeDecorator
    {
        private readonly decimal _milkCost = 0.5M;

        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override decimal Cost()
        {
            return base.Cost() + _milkCost;
        }
    }

    public class SugarDecorator : CoffeeDecorator
    {
        private readonly decimal _sugarCost = 0.6M;

        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override decimal Cost()
        {
            return base.Cost() + _sugarCost;
        }
    }
}
