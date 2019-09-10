using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUtilityLibrary
{
    public class HttpUtility
    {
        public List<string> ExtractLinks(string rawCode)
        {
            List<string> links = new List<string>();

            string startSquence = "<a href=\"";
            string endSequence = "\"";

            rawCode = rawCode.ToLower();

            while (rawCode.IndexOf("<a href") != -1)
            {
                int start = rawCode.IndexOf(startSquence) + startSquence.Length;
                int end = rawCode.IndexOf(endSequence, start);

                //Extract the link, and add it to the list
                if (end > start)
                {
                    string link = rawCode.Substring(start, end - start);

                    if (link != string.Empty)
                    {
                        if (!link.StartsWith("http://"))
                        {
                            //It's a relative link, add a ..
                            link = "../" + link;
                        }

                        links.Add(link);
                    }
                }

                //Trim the raw data
                rawCode = rawCode.Substring(end + endSequence.Length);
            }

            return links;
        }

        public string GenerateGetSet(string input, bool get, bool set)
        {
            StringReader reader = new StringReader(input);
            StringBuilder build = new StringBuilder();

            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();

                //Remove any initializing values
                int equalIndex = line.IndexOf('=');
                if (equalIndex != -1)
                    line = line.Substring(0, equalIndex);

                //Remove extra space at the start and end of the line
                line = line.TrimStart(' ');
                line = line.TrimEnd(' ');

                //Skip empty lines
                if (line == string.Empty)
                    continue;

                string[] parts = line.Split(' ');

                string type = string.Empty;
                string name = string.Empty;

                if (parts.Length == 2)
                {
                    //[type] [name]
                    type = parts[0];
                    name = parts[1];
                }
                else if (parts.Length == 3)
                {
                    //[accessor] [type] [name]
                    type = parts[1];
                    name = parts[2];
                }
                else
                    continue; //unrecognized string

                //Remove the semicolon at the end
                name = name.TrimEnd(';');

                string header = "public " + type + " " + Capitalize(name.TrimStart('_'));
                string getter = "    get { return this." + name + "; }";
                string setter = "    set { this." + name + " = value; }";

                //Add the strings to the final string
                build.AppendLine(header);
                build.AppendLine("{");
                if (get)
                    build.AppendLine(getter);
                if (set)
                    build.AppendLine(setter);
                build.AppendLine("}");
                build.AppendLine(""); //emtpy line
            }
            return build.ToString();
        }

        private string Capitalize(string input)
        {
            //Verify input
            if (string.IsNullOrEmpty(input)) return string.Empty;
            if (input.Length == 1) return input.ToUpper();

            if (char.IsUpper(input[0]))
                return input; //already capitalized
            else
            {
                char[] outputChars = input.ToCharArray();
                outputChars[0] = char.ToUpper(outputChars[0]);

                return new string(outputChars);
            }
        }

    }
}
