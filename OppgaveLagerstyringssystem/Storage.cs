namespace OppgaveLagerstyringssystem
{
    internal class Storage
    {
        private List<IProduct> _products;

        public Storage()
        {
            _products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            // Fjerner det første produktet som er lik "product"
            _products.Remove(product);
        }

        public IProduct? GetProductByName(string name)
        {
            foreach (var product in _products)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }

        public void ShowProducts()
        {
            foreach (var product in _products)
            {
                product.PrintOutInfo();
            }
            Console.WriteLine();
        }
    }
}
