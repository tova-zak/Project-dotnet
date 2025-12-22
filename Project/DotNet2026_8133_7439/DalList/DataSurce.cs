namespace Dal
{
    internal static class DataSource
    {
        internal static List<Product?> Products = new List<Product?>();
        internal static List<Customer?> Customers = new List<Customer?>();
        internal static List<Sale?> Sales = new List<Sale?>();
        internal  static class Config
        {
           // internal const int StartIdProduct=1;
            internal const int StartSaleId = 1222;
            //internal const int StartIdProduct = 1;
            private static int _currentSaletId = StartSaleId;

            static int NextProductId
            {
                get
                {
                    return _currentSaletId++;
                }


            }
        }
}
