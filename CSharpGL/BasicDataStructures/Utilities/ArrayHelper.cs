using System;
using System.Text;

namespace CSharpGL
{
    /// <summary>
    /// Helper class for array.
    /// </summary>
    public static class ArrayHelper
    {
        /// <summary>
        /// Print elements in format 'element, element, element, ...'
        /// </summary>
        /// <param name="array"></param>
        /// <param name="seperator"></param>
        /// <returns></returns>
        public static string PrintArray(this System.Collections.IEnumerable array, string seperator = " ")
        {
            if (array == null) { return string.Empty; }

            var b = new StringBuilder();
            foreach (object item in array)
            {
                b.Append(item);
                b.Append(seperator);
            }

            return b.ToString();
        }

        /// <summary>
        /// Print elements in format 'x,y,z; x,y,z; ...'
        /// </summary>
        /// <param name="array"></param>
        /// <param name="components">2, 3, or 4.</param>
        /// <param name="componentSeparator"></param>
        /// <param name="vectorSeparator"></param>
        /// <returns></returns>
        public static string PrintVectors(this float[] array, int components = 3, string componentSeparator = ",", string vectorSeparator = "\r\n")
        {
            if (components < 1) { throw new ArgumentOutOfRangeException("components"); }

            if (array == null) { return string.Empty; }

            var b = new StringBuilder();
            int counter = 0;
            foreach (float item in array)
            {
                b.Append(item.ToShortString());
                counter++;
                if (counter % components == 0)
                {
                    b.Append(vectorSeparator);
                    counter = 0;
                }
                else
                {
                    b.Append(componentSeparator);
                }
            }

            return b.ToString();
        }
    }
}