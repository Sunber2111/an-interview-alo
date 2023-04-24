namespace AnCodeExample.Questions
{
    public static class Problem7
    {
        public static string Resolved(string input, string keyword, string replaceTo)
        {
            var output = "";
            var inputList = input.Split(' ');

            foreach (var item in inputList)
            {
                if (item == keyword)
                {
                    output = $"{output} {replaceTo}";
                }
                else
                {
                    output = $"{output} {item}";
                }
            }

            return output.Trim();
        }
    }
}
