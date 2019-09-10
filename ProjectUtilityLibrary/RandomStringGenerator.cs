using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUtilityLibrary
{
    public class RandomStringGenerator
    {
        private Random r;
        const string UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string LOWERCASE = "abcdefghijklmnopqrstuvwxyz";
        const string NUMBERS = "0123456789";
        const string SYMBOLS = @"~`!@#$%^&*()-_=+<>?:,./\[]{}|'";
        public RandomStringGenerator()
        {
            r = new Random();
        }

        public RandomStringGenerator(int seed)
        {
            r = new Random(seed);
        }

        public virtual string NextString(int length)
        {
            return NextString(length, true, true, true, true);
        }

        public virtual string NextString(int length, bool lowerCase, bool upperCase, bool numbers, bool symbols)
        {
            char[] charArray = new char[length];
            string charPool = string.Empty;

            //Build character pool
            if (lowerCase)
                charPool += LOWERCASE;

            if (upperCase)
                charPool += UPPERCASE;

            if (numbers)
                charPool += NUMBERS;

            if (symbols)
                charPool += SYMBOLS;

            //Build the output character array
            for (int i = 0; i < charArray.Length; i++)
            {
                //Pick a random integer in the character pool
                int index = r.Next(0, charPool.Length);

                //Set it to the output character array
                charArray[i] = charPool[index];
            }

            return new string(charArray);
        }
    }

    public class StringProcessing
    {
        ////Processing with strings
        //Use for small to medium strings

        //Swaps the cases in a string
        //word -> WORD
        //Word -> wORD
        //WoRd -> wOrD
        public string SwapCases(string input)
        {
            string ret = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (string.Compare(input.Substring(i, 1), input.Substring(i, 1).ToUpper(), false) == 0)
                    ret += input.Substring(i, 1).ToLower();
                else
                    ret += input.Substring(i, 1).ToUpper();
            }
            return ret;
        }

        //Alternates cases between letters of a string, letting the user pick if the first letter is capitalized
        public string AlternateCases(string input, bool firstIsUpper)
        {
            string ret = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (firstIsUpper)
                    ret += input.Substring(i, 1).ToUpper();
                else
                    ret += input.Substring(i, 1).ToLower();

                firstIsUpper = !firstIsUpper;
            }

            return ret;
        }

        //Removes vowels from a word
        //remove -> rmv
        public string RemoveVowels(string input)
        {
            string ret = "";
            string currentLetter;
            for (int i = 0; i < input.Length; i++)
            {
                currentLetter = input.Substring(i, 1);

                if (string.Compare(currentLetter, "a", true) != 0 &&
                    string.Compare(currentLetter, "e", true) != 0 &&
                    string.Compare(currentLetter, "i", true) != 0 &&
                    string.Compare(currentLetter, "o", true) != 0 &&
                    string.Compare(currentLetter, "u", true) != 0)
                {
                    //Not a vowel, add it
                    ret += currentLetter;
                }
            }
            return ret;
        }

        //Removes vowels from a word
        //remove -> eoe
        public string KeepVowels(string input)
        {
            string ret = "";
            string currentLetter;
            for (int i = 0; i < input.Length; i++)
            {
                currentLetter = input.Substring(i, 1);

                if (string.Compare(currentLetter, "a", true) == 0 ||
                    string.Compare(currentLetter, "e", true) == 0 ||
                    string.Compare(currentLetter, "i", true) == 0 ||
                    string.Compare(currentLetter, "o", true) == 0 ||
                    string.Compare(currentLetter, "u", true) == 0)
                {
                    //A vowel, add it
                    ret += currentLetter;
                }
            }
            return ret;
        }

        //Returns an array converted into a string
        public string ArrayToString(Array input, string separator)
        {
            string ret = "";
            for (int i = 0; i < input.Length; i++)
            {
                ret += input.GetValue(i).ToString();
                if (i != input.Length - 1)
                    ret += separator;
            }
            return ret;
        }

        //Inserts a separator after every letter
        //hello, - -> h-e-l-l-o
        public string InsertSeparator(string input, string separator)
        {
            string ret = "";
            for (int i = 0; i < input.Length; i++)
            {
                ret += input.Substring(i, 1);
                if (i != input.Length - 1)
                    ret += separator;
            }
            return ret;
        }

        //Inserts a separator after every Count letters
        //hello, -, 2 -> he-ll-o
        public string InsertSeparatorEvery(string input, string separator, int count)
        {
            string ret = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (i + count < input.Length)
                    ret += input.Substring(i, count);
                else
                    ret += input.Substring(i);

                if (i != input.Length - 1)
                    ret += separator;
            }
            return ret;
        }

        //Reverses a string
        //Hello -> olleH
        public string Reverse(string input)
        {
            string ret = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                ret += input.Substring(i, 1);
            }
            return ret;
        }
    }

    public class StringBuilderProcessing
    {
        ////Processing with StringBuilder
        //Use for small to medium strings

        //Swaps the cases in a string
        //word -> WORD
        //Word -> wORD
        //WoRd -> wOrD
        public string SwapCases(string input)
        {
            StringBuilder ret = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (string.Compare(input.Substring(i, 1), input.Substring(i, 1).ToUpper(), false) == 0)
                    ret.Append(input.Substring(i, 1).ToLower());
                else
                    ret.Append(input.Substring(i, 1).ToUpper());
            }
            return ret.ToString();
        }

        //Alternates cases between letters of a string, letting the user pick if the first letter is capitalized
        public string AlternateCases(string input, bool firstIsUpper)
        {
            StringBuilder ret = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (firstIsUpper)
                    ret.Append(input.Substring(i, 1).ToUpper());
                else
                    ret.Append(input.Substring(i, 1).ToLower());

                firstIsUpper = !firstIsUpper;
            }

            return ret.ToString();
        }

        //Removes vowels from a word
        //remove -> rmv
        public string RemoveVowels(string input)
        {
            StringBuilder ret = new StringBuilder();
            string currentLetter;
            for (int i = 0; i < input.Length; i++)
            {
                currentLetter = input.Substring(i, 1);

                if (string.Compare(currentLetter, "a", true) != 0 &&
                    string.Compare(currentLetter, "e", true) != 0 &&
                    string.Compare(currentLetter, "i", true) != 0 &&
                    string.Compare(currentLetter, "o", true) != 0 &&
                    string.Compare(currentLetter, "u", true) != 0)
                {
                    //Not a vowel, add it
                    ret.Append(currentLetter);
                }
            }
            return ret.ToString();
        }

        //Removes vowels from a word
        //remove -> eoe
        public string KeepVowels(string input)
        {
            StringBuilder ret = new StringBuilder();
            string currentLetter;
            for (int i = 0; i < input.Length; i++)
            {
                currentLetter = input.Substring(i, 1);

                if (string.Compare(currentLetter, "a", true) == 0 ||
                    string.Compare(currentLetter, "e", true) == 0 ||
                    string.Compare(currentLetter, "i", true) == 0 ||
                    string.Compare(currentLetter, "o", true) == 0 ||
                    string.Compare(currentLetter, "u", true) == 0)
                {
                    //A vowel, add it
                    ret.Append(currentLetter);
                }
            }
            return ret.ToString();
        }

        //Returns an array converted into a string
        public string ArrayToString(Array input, string separator)
        {
            StringBuilder ret = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                ret.Append(input.GetValue(i).ToString());
                if (i != input.Length - 1)
                    ret.Append(separator);
            }
            return ret.ToString();
        }

        //Inserts a separator after every letter
        //hello, - -> h-e-l-l-o
        public string InsertSeparator(string input, string separator)
        {
            StringBuilder ret = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                ret.Append(input.Substring(i, 1));
                if (i != input.Length - 1)
                    ret.Append(separator);
            }
            return ret.ToString();
        }

        //Inserts a separator after every Count letters
        //hello, -, 2 -> he-ll-o
        public string InsertSeparatorEvery(string input, string separator, int count)
        {
            StringBuilder ret = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (i + count < input.Length)
                    ret.Append(input.Substring(i, count));
                else
                    ret.Append(input.Substring(i));

                if (i != input.Length - 1)
                    ret.Append(separator);
            }
            return ret.ToString();
        }

        //Reverses a string
        //Hello -> olleH
        public string Reverse(string input)
        {
            StringBuilder ret = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                ret.Append(input.Substring(i, 1));
            }
            return ret.ToString();
        }
    }

    public class StringFunction
    {
        //Capitalizes a word or sentence
        //word -> Word
        //OR
        //this is a sentence -> This is a sentence
        public string Capitalize(string input)
        {
            if (input.Length == 0) return "";
            if (input.Length == 1) return input.ToUpper();

            return input.Substring(0, 1).ToUpper() + input.Substring(1);
        }

        //Checks whether a word or sentence is capitalized
        //Word -> True
        //OR
        //This is a sentence -> True
        public bool IsCapitalized(string input)
        {
            if (input.Length == 0) return false;
            return string.Compare(input.Substring(0, 1), input.Substring(0, 1).ToUpper(), false) == 0;
        }

        //Checks whether a string is in all lower case
        //word -> True
        //Word -> False
        public bool IsLowerCase(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (string.Compare(input.Substring(i, 1), input.Substring(i, 1).ToLower(), false) != 0)
                    return false;
            }
            return true;
        }

        //Checks whether a string is in all upper case
        //word -> False
        //Word -> False
        //WORD -> True
        public bool IsUpperCase(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (string.Compare(input.Substring(i, 1), input.Substring(i, 1).ToUpper(), false) != 0)
                    return false;
            }
            return true;
        }

        //Alternates cases between letters of a string, first letter's case stays the same
        //Hi -> Hi
        //longstring -> lOnGsTrInG
        public string AlternateCases(string input)
        {
            if (input.Length == 0) return "";
            if (input.Length == 1) return input; //Cannot automatically alternate
            bool firstIsUpper = string.Compare(input.Substring(0, 1), input.Substring(0, 1).ToUpper(), false) != 0;
            string ret = input.Substring(0, 1);
            for (int i = 1; i < input.Length; i++)
            {
                if (firstIsUpper)
                    ret += input.Substring(i, 1).ToUpper();
                else
                    ret += input.Substring(i, 1).ToLower();

                firstIsUpper = !firstIsUpper;
            }

            return ret;
        }

        //Checks to see if a string has alternate cases
        //lOnGsTrInG -> True
        public bool IsAlternateCases(string input)
        {
            if (input.Length <= 1) return false;

            bool lastIsUpper = string.Compare(input.Substring(0, 1), input.Substring(0, 1).ToUpper(), false) == 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (lastIsUpper)
                {
                    if (string.Compare(input.Substring(i, 1), input.Substring(i, 1).ToLower(), false) != 0)
                        return false;
                }
                else
                {
                    if (string.Compare(input.Substring(i, 1), input.Substring(i, 1).ToUpper(), false) != 0)
                        return false;
                }

                lastIsUpper = !lastIsUpper;
            }

            return true;
        }

        //Counts total number of a char or chars in a string
        //hello, l -> 2
        //hello, el -> 1
        public int CountTotal(string input, string chars, bool ignoreCases)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!(i + chars.Length > input.Length) &&
                    string.Compare(input.Substring(i, chars.Length), chars, ignoreCases) == 0)
                {
                    count++;
                }
            }
            return count;
        }

        //Checks to see if a string contains vowels
        //hello -> True
        //rmv -> False
        public bool HasVowels(string input)
        {
            string currentLetter;
            for (int i = 0; i < input.Length; i++)
            {
                currentLetter = input.Substring(i, 1);

                if (string.Compare(currentLetter, "a", true) == 0 ||
                  string.Compare(currentLetter, "e", true) == 0 ||
                  string.Compare(currentLetter, "i", true) == 0 ||
                  string.Compare(currentLetter, "o", true) == 0 ||
                  string.Compare(currentLetter, "u", true) == 0)
                {
                    //A vowel found
                    return true;
                }
            }

            return false;
        }

        //Checks if string is nothing but spaces
        //"        " -> True
        public bool IsSpaces(string input)
        {
            if (input.Length == 0) return false;
            return input.Replace(" ", "").Length == 0;
        }

        //Checks if the string has all the same letter/number
        //aaaaaaaaaaaaaaaaaaa -> true
        //aaaaaaaaaaaaaaaaaab -> false
        public bool IsRepeatedChar(string input)
        {
            if (input.Length == 0) return false;
            return input.Replace(input.Substring(0, 1), "").Length == 0;
        }

        //Checks if string has only numbers
        //12453 -> True
        //234d3 -> False
        public bool IsNumeric(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!(Convert.ToInt32(input[i]) >= 48 && Convert.ToInt32(input[i]) <= 57))
                {
                    //Not integer value
                    return false;
                }
            }
            return true;
        }

        //Checks if the string contains numbers
        //hello -> False
        //h3llo -> True
        public bool HasNumbers(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, "\\d+");
        }

        //Checks if string is numbers and letters
        //Test1254 -> True
        //$chool! -> False
        public bool IsAlphaNumberic(string input)
        {
            char currentLetter;
            for (int i = 0; i < input.Length; i++)
            {
                currentLetter = input[i];

                if (!(Convert.ToInt32(currentLetter) >= 48 && Convert.ToInt32(currentLetter) <= 57) &&
                    !(Convert.ToInt32(currentLetter) >= 65 && Convert.ToInt32(currentLetter) <= 90) &&
                    !(Convert.ToInt32(currentLetter) >= 97 && Convert.ToInt32(currentLetter) <= 122))
                {
                    //Not a number or a letter
                    return false;
                }
            }
            return true;
        }

        //Checks if a string contains only letters
        //Hi -> True
        //Hi123 -> False
        public bool isLetters(string input)
        {
            char currentLetter;
            for (int i = 0; i < input.Length; i++)
            {
                currentLetter = input[i];

                if (!(Convert.ToInt32(currentLetter) >= 65 && Convert.ToInt32(currentLetter) <= 90) &&
                    !(Convert.ToInt32(currentLetter) >= 97 && Convert.ToInt32(currentLetter) <= 122))
                {
                    //Not a letter
                    return false;
                }
            }
            return true;
        }

        // Returns the initials of a name or sentence
        //capitalize - whether to make intials capitals
        //includeSpace - to return intials separated (True - J. S. or False - J.S.)
        //John Smith -> J. S. or J.S.
        public string GetInitials(string input, bool capitalize, bool includeSpace)
        {
            string[] words = input.Split(new char[] { ' ' });

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                    if (capitalize)
                        words[i] = words[i].Substring(0, 1).ToUpper() + ".";
                    else
                        words[i] = words[i].Substring(0, 1) + ".";
            }

            if (includeSpace)
                return string.Join(" ", words);
            else
                return string.Join("", words);
        }

        //Capitalizes the first letter of every word
        //the big story -> The Big Story
        public string GetTitle(string input)
        {
            string[] words = input.Split(new char[] { ' ' });

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                    words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1);
            }

            return string.Join(" ", words);
        }

        //Very much like the GetTitle function, capitalizes the first letter of every word
        //Additional function is, mcdonald -> McDonald, machenry -> MacHenry
        //Credits to ShutlOrbit (http://www.thirdstagesoftware.com) from CodeProject
        public string GetNameCasing(string input)
        {
            string[] words = input.Split(new char[] { ' ' });

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1);
                    if (words[i].StartsWith("Mc") && words[i].Length > 2)
                        words[i] = words[i].Substring(0, 2) + words[i].Substring(2, 1).ToUpper() + words[i].Substring(3);
                    else if (words[i].StartsWith("Mac") && words[i].Length > 3)
                        words[i] = words[i].Substring(0, 3) + words[i].Substring(3, 1).ToUpper() + words[i].Substring(4);
                }
            }
            return string.Join(" ", words);
        }

        // Checks whether the first letter of each word is capitalized
        //The Big Story -> True
        //The big story -> False
        public bool IsTitle(string input)
        {
            string[] words = input.Split(new char[] { ' ' });

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                    if (string.Compare(words[i].Substring(0, 1).ToUpper(), words[i].Substring(0, 1), false) != 0)
                        return false;
            }
            return true;
        }

        //Checks if string is a valid email address format
        //name@place.com -> True
        //hahaimfaking -> False
        //(Function works assuming the last part is no bigger than 3 letters (com, net, org))
        public bool IsEmailAddress(string input)
        {
            if (input.IndexOf('@') != -1)
            {
                int indexOfDot = input.LastIndexOf('.');
                if (input.Length - indexOfDot > 0 && input.Length - indexOfDot <= 4)
                    return true;
            }
            return false;
        }

        //Returns all the locations of a char in a string
        //Hello, l -> 2, 3
        //Hello, o -> 4
        //Bob, 1 -> -1
        public int[] IndexOfAll(string input, string chars)
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input.Substring(i, 1) == chars)
                    indices.Add(i);
            }

            if (indices.Count == 0)
                indices.Add(-1);

            return indices.ToArray();
        }

        //Return a rating for how strong the string is as a password
        //Max rating is 100
        //Credits for original function to D. Rijmenants
        //If there are problems with copyright contact us and we will delete it
        public int PasswordStrength(string input)
        {
            double total = 0;
            bool hasUpperCase = false;
            bool hasLowerCase = false;

            total = input.Length * 3;

            char currentLetter;
            for (int i = 0; i < input.Length; i++)
            {
                currentLetter = input[i];
                if (Convert.ToInt32(currentLetter) >= 65 && Convert.ToInt32(currentLetter) <= 92)
                    hasUpperCase = true;

                if (Convert.ToInt32(currentLetter) >= 97 && Convert.ToInt32(currentLetter) <= 122)
                    hasLowerCase = true;
            }

            if (hasUpperCase && hasLowerCase) total *= 1.2;

            for (int i = 0; i < input.Length; i++)
            {
                currentLetter = input[i];
                if (Convert.ToInt32(currentLetter) >= 48 && Convert.ToInt32(currentLetter) <= 57) //Numbers
                    if (hasUpperCase && hasLowerCase) total *= 1.4;
            }

            for (int i = 0; i < input.Length; i++)
            {
                currentLetter = input[i];
                if ((Convert.ToInt32(currentLetter) <= 47 && Convert.ToInt32(currentLetter) >= 123) ||
                    (Convert.ToInt32(currentLetter) >= 58 && Convert.ToInt32(currentLetter) <= 64)) //symbols
                {
                    total *= 1.5;
                    break;
                }
            }

            if (total > 100.0) total = 100.0;

            return (int)total;
        }

        //Gets the char in a string at a given position, but counting from right to left
        //string, 0 -> g
        public char CharRight(string input, int index)
        {
            if (input.Length - index - 1 >= input.Length ||
                input.Length - index - 1 < 0)
                return new char();

            string str = input.Substring(input.Length - index - 1, 1);
            return str[0];
        }

        //Gets the char in a string from a starting position plus the index
        //string, 3, 1 -> n
        public char CharMid(string input, int startingIndex, int countIndex)
        {
            if (startingIndex + countIndex < input.Length)
            {
                string str = input.Substring(startingIndex + countIndex, 1);
                return str[0];
            }
            else
                return new char();
        }

        //Function that works the same way as the default Substring, but
        //it takes Start and End (exclusive) parameters instead of Start and Length
        //hello, 1, 3 -> el
        public string SubstringEnd(string input, int start, int end)
        {
            if (start > end) //Flip the values
            {
                start ^= end;
                end = start ^ end;
                start ^= end;
            }

            if (end > input.Length) end = input.Length; //avoid errors

            return input.Substring(start, end - start);

        }

        //Splits strings, but leaves anything within quotes
        //(Has issues with nested quotes
        //This is a "very long" string ->
        //This
        //is
        //a
        //very long
        //string
        public string[] SplitQuotes(string input, bool ignoreQuotes, string separator)
        {
            if (ignoreQuotes)
                return input.Split(separator.ToCharArray());
            else
            {
                string[] words = input.Split(separator.ToCharArray());
                List<string> newWords = new List<string>();

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].StartsWith('"'.ToString()))
                    {
                        List<string> linked = new List<string>();
                        for (int y = i; y < words.Length; y++)
                        {
                            if (words[y].EndsWith('"'.ToString()))
                            {
                                linked.Add(words[y].Substring(0, words[y].Length - 1));
                                i = y;
                                break;
                            }
                            else
                            {
                                if (words[y].StartsWith('"'.ToString()))
                                    linked.Add(words[y].Substring(1));
                            }
                        }
                        newWords.Add(string.Join(separator, linked.ToArray()));
                        linked.Clear();
                    }
                    else
                        newWords.Add(words[i]);
                }
                return newWords.ToArray();
            }
        }
    }

}
