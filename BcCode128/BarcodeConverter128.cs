namespace BcCode128
{
    /// <summary>
    /// Code 128
    /// Convert an input string to the equivilant string including start and stop characters.
    /// This object compresses the values to the shortest possible code 128 barcode format 
    /// </summary>
    /// <see cref="http://www.jtbarton.com/Barcodes/BarcodeStringBuilderExample.aspx"/>
    public static class BarcodeConverter128
    {
        private const string StartCodeC = ">;";
        private const string StartCodeB = ">:";
        private const string ModeCInvocation = ">5";
        private const string ModeBInvocation = ">6";

        /// <summary>
        ///     Converts an input string to the equivilant zpl string.
        /// </summary>
        /// <param name="value">String to be encoded</param>
        /// <returns>Encoded string start/stop and checksum characters included</returns>
        public static string StringToBarcodeZplFormat(string value)
        {
            
            // Parameters : a string
            // Return     : a string which give the bar code when it is dispayed with CODE128.TTF font
            // 			 : an empty string if the supplied parameter is no good
            // modify by Abraham Chen
            int charPos, minCharPos;
            int currentChar;
            bool isTableB = true, isValid = true;
            var returnValue = string.Empty;


            if (value.Length > 0)
            {
                // Check for valid characters
                for (var charCount = 0; charCount < value.Length; charCount++)
                {
                    //currentChar = char.GetNumericValue(value, charPos);
                    currentChar = char.Parse(value.Substring(charCount, 1));
                    if (!(currentChar >= 32 && currentChar <= 126))
                    {
                        isValid = false;
                        break;
                    }
                }

                // Barcode is full of ascii characters, we can now process it
                if (isValid)
                {
                    charPos = 0;
                    while (charPos < value.Length)
                    {
                        if (isTableB)
                        {
                            // See if interesting to switch to table C
                            // yes for 4 digits at start or end, else if 6 digits
                            if (charPos == 0 || charPos + 4 == value.Length)
                                minCharPos = 4;
                            else
                                minCharPos = 6;


                            minCharPos = IsNumber(value, charPos, minCharPos);

                            if (minCharPos < 0)
                            {
                                // Choice table C
                                if (charPos == 0)
                                {
                                    // Starting with table C
                                    returnValue = StartCodeC; // char.ConvertFromUtf32(205);
                                }
                                else
                                {
                                    // Switch to table C
                                    returnValue = returnValue + ModeCInvocation;
                                }
                                isTableB = false;
                            }
                            else
                            {
                                if (charPos == 0)
                                {
                                    // Starting with table B
                                    returnValue = StartCodeB; // char.ConvertFromUtf32(204);
                                }
                            }
                        }

                        if (!isTableB)
                        {
                            // We are on table C, try to process 2 digits
                            minCharPos = 2;
                            minCharPos = IsNumber(value, charPos, minCharPos);
                            if (minCharPos < 0) // OK for 2 digits, process it
                            {
                               var _currentChar = value.Substring(charPos, 2);
                                returnValue = returnValue + _currentChar;
                                charPos += 2;
                            }
                            else
                            {
                                // We haven't 2 digits, switch to table B
                                returnValue = returnValue + ModeBInvocation;
                                isTableB = true;
                            }
                        }

                        if (isTableB)
                        {
                            // Process 1 digit with table B
                            returnValue = returnValue + value.Substring(charPos, 1);
                            charPos++;
                        }
                    }


                }
            }

            return returnValue;
        }

        private static int IsNumber(string inputValue, int charPos, int minCharPos)
        {
            // if the MinCharPos characters from CharPos are numeric, then MinCharPos = -1
            minCharPos--;
            if (charPos + minCharPos < inputValue.Length)
            {
                while (minCharPos >= 0)
                {
                    if ((int)char.Parse(inputValue.Substring(charPos + minCharPos, 1)) < 48
                        || (int)char.Parse(inputValue.Substring(charPos + minCharPos, 1)) > 57)
                    {
                        break;
                    }
                    minCharPos--;
                }
            }
            return minCharPos;
        }
    }
}
