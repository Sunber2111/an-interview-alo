namespace AnCodeExample.Questions
{
    public static class Problem6
    {
        public static long Resolved(string input,string keyword)
        {
            var output = 0;
            var inputList = input.Split(' ');

            foreach (var item in inputList)
            {
                if (item == keyword)
                    output += 1;
            }

            return output;
        }
    }
}
