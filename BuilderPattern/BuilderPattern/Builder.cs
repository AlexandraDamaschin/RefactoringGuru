namespace BuilderPattern
{
    public class Builder : IBuilder
    {
        private Product _product = new Product();

        public Builder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        public void BuildPartA()
        {
            this._product.Add("Part A1");
        }

        public void BuildPartB()
        {
            this._product.Add("Part B1");
        }

        public void BuildPartC()
        {
            this._product.Add("Part C1");
        }

        public Product GetProduct()
        {
            Product result = _product;

            Reset();

            return result;
        }
    }
}
