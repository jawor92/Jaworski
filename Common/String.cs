using System;

namespace Common
{
    public class StringWork
    {
        public string WhiteSpaceInsert(string source)
        {
            string result = string.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (var letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result += " ";
                    }

                    result += letter;
                }
            }

            return result;
        }
    }
}
