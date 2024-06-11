namespace OppgaveLagerstyringssystem
{
    internal class Storage
    {
        private List<IProduct> _products;

        public Storage()
        {
            _products =
                [
                    new Food("Apple", 5.99, 20, 12,2026),
                    new Electronic("Dell keyboard", 538, 6),
                    new Clothes("t-shirt", 269.77, "M"),
                ];
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
