namespace AnCodeExample.Questions
{
    public class Problem3
    {
        public static bool Resolved(string input)
        {
            var len = input.Length;
            var lenLoop = len / 2;

            for (int i = 0; i < lenLoop; i++)
            {
                if (input[i] == input[len - i - 1])
                    continue;
                else
                    return false;
            }

            return true;
        }
    }
}
