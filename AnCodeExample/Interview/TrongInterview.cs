namespace AnCodeExample.Interview
{
    public class TrongInterview
    {
        public static string Resolved(string input)
        {
            var output = "";
            var counter = 0;
            var prevChar = ' ';
            for (int i = 0; i < input.Length; i++)
            {
                if(prevChar == input[i])
                {
                    counter++;
                }
                else
                {
                    if(prevChar!=' ')
                        output = $"{output}{prevChar}{counter}";

                    prevChar = input[i];
                    counter = 1;
                }
            }

            // last charactor
            output = $"{output}{prevChar}{counter}";
            return output;
        }
    }
}
