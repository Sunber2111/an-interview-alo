namespace AnCodeExample.Questions
{
    public static class Problem5
    {
        public static string Resolved(string input)
        {
            string output = "";

            for (int i = input.Length-1; i >=0; i--)
            {
                output += input[i];
            }

            return output;
        }

    }
}
