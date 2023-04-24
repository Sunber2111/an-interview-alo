﻿namespace AnCodeExample.Questions
{
    public static class Problem1
    {
        public static char Resolved(string input)
        {
            var dicChars = new Dictionary<char, long>();

            foreach (char c in input)
            {
                if(dicChars.ContainsKey(c))
                {
                    dicChars[c] += 1;
                }
                else
                {
                    dicChars.Add(c, 1);
                }
            }
            
            return dicChars.OrderByDescending(x => x.Value).FirstOrDefault().Key;
            
        }

        public static char ResolvedOptimize(string input)
        {
            if (input.Length == 0 || String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input))
                throw new Exception("Wrong input value");

            if(input.Length == 1)   
                return input[0];

            var dicChars = new Dictionary<char, long>();
            var halfInputLen = (input.Length / 2)+1;

            foreach (char c in input)
            {
                if (dicChars.ContainsKey(c))
                {
                    dicChars[c] += 1;
                    if (dicChars[c] >= halfInputLen)
                        return c;
                }
                else
                {
                    dicChars.Add(c, 1);
                }
            }

            return dicChars.OrderByDescending(x => x.Value).FirstOrDefault().Key;

        }
    }
}
