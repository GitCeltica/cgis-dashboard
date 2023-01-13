namespace cGisDashBoard.Helpers.Ultis
{
    public static class Format
    {
        public static string CommaToDot(double value)
        {
            string res = value.ToString();
            res = res.Replace(',', '.');
            return res;
        }

        public static string CommaToDot(decimal value)
        {
            string res = value.ToString();
            res = res.Replace(',', '.');
            return res;
        }
    }
}
