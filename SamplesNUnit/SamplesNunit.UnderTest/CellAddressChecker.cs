using System.Text.RegularExpressions;

namespace SamplesNunit.UnderTest
{
    public class CellAddressChecker
    {
        public bool Check(string cellAddress)
        {
            if (string.IsNullOrEmpty(cellAddress))
            {
                return false;
            }

            // 形如 "B3" 或 "AB34"
            return Regex.IsMatch(cellAddress, "^[a-z]+[1-9]+[0-9]*$", RegexOptions.IgnoreCase);
        }
    }
}
