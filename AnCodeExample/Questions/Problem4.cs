namespace AnCodeExample.Questions
{
    public static class Problem4
    {
        public static bool Resolved(string input)
        {
            var specialChars  = new HashSet<char>()
            {
                '#',
                ';',
                ',',
                '.',
                '?',
                '~',
                '$',
                '%'
            };

            foreach (var character in input)
            {
                if(specialChars.Contains(character))
                    return true;
            }

            return false;
        }
    }
}
