namespace Dal;
using DalFacade;

internal static class DataSource
{
    internal static List<DO.Product?> Products = new ();
    internal static List<DO.Customer?> Customers = new();
    internal static List<DO.Sale?> Sales = new ();
    internal  static class Config
    {
        internal const int MinIdProduct=1;
        internal const int MinSaleId = 1222;

        private static int _currentProductId = MinIdProduct;
        private static int _currentSaleId = MinSaleId;

         static int GetNextProductId()
        {
            return _currentProductId++;
        }

         static int GetNextSaleId()
        {
            return _currentSaleId++;
        }

    }
}
