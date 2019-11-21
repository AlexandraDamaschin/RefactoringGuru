namespace FactoryMethod
{
    public interface IProduct
    {
        string Operation();
    }

    //other classes which implements the product interface
    class Product1 : IProduct
    {
        public string Operation()
        {
            return "{Result of product 1}";
        }
    }

    class Product2 : IProduct
    {
        public string Operation()
        {
            return "{Result of product 2}";
        }
    }
}
