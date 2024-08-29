namespace SudokuUWP.Library
{
    /// <summary>
    /// Helper methods used here and there; in a separate class mainly for testability.
    /// </summary>
    public class HelperMethods
    {

        /// <summary>
        /// Helper method to check that each digit within a string is a number from 0 to 9. Empty
        /// or null strings return true.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool IsDigitsOnly(string str)
        {
            if (str == null || str == "")
                return true;

            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }


        /// <summary>
        /// Check if a string of characters contains 1 or 0 only, no other characters allowed.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool IsZeroOrOneOnly(string str)
        {
            if (str == null || str == "")
                return true;

            foreach (char c in str)
            {
                if (c < '0' || c > '1')
                    return false;
            }

            return true;
        }
    }
}
