namespace FactoryMethod
{
    abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string Operation()
        {
            var product = FactoryMethod();

            var result = "Creator worked with:" + product.Operation();

            return result;
        }
    }

    // other creators which inherit the Creator
    class ChildOfCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new Product1();
        }
    }

    class ChildOfCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new Product2();
        }
    }
}
