using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnCodeExample.Interview
{
    public static class NamQuestion
    {
        /// <summary>
        /// Level 1
        /// </summary>
        /// <param name="input"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string Resolved(string input, int index)
        {
            var output = "";
            for (int i = index; i < input.Length; i++)
            {
                output += input[i];
            }
            return output;
        }

        /// <summary>
        /// Level 2
        /// </summary>
        /// <param name="input"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string Resolved2(string input, int index)
        {
            var startIndex = index;

            if(input.Length <= index)
            {
                startIndex = input.Length%index;
            }

            var output = "";
            for (int i = startIndex; i < input.Length; i++)
            {
                output += input[i];
            }
            return output;
        }

        /// <summary>
        /// Level 3
        /// </summary>
        /// <param name="input"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string Resolved3(string input, int index)
        {
            if(index < 0)
            {
                index = Math.Abs(index);
            }

            var startIndex = index;
            if (input.Length <= index)
            {
                startIndex = input.Length % index;
            }

            var output = "";
            for (int i = startIndex; i < input.Length; i++)
            {
                output += input[i];
            }
            return output;
        }
    }
}
