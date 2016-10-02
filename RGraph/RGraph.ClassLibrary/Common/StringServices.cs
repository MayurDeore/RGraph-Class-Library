using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGraph.Common
{
    public abstract class StringServices 
    {
        /// <summary>
        /// Returns StringBuilder initialized with "[" 
        /// </summary>
        /// <returns>StringBuilder appended with "["</returns>
        protected StringBuilder initializeString()
        {
            var initialString = new StringBuilder();
            return initialString.Append("[");
        }
        /// <summary>
        /// Returns finalized StringBuilder by appending "]" for JSON data
        /// </summary>
        /// <param name="_string">Finalized JSON string</param>
        /// <returns>Finalized JSON String</returns>
        protected string finalizeString(StringBuilder _string)
        {
            if (!string.IsNullOrEmpty(_string.ToString()))
            {
                _string = _string.Remove(_string.Length - 1, 1);
                _string.Append("]"); 

                return _string.ToString();
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Returns StringBuilder by appending value (as per Type) and ","
        /// </summary>
        /// <typeparam name="T">Type of value (int or string)</typeparam>
        /// <param name="_string">JSON stringbuilder to be appended with value</param>
        /// <param name="value">This value will be appended</param>
        /// <returns>StringBuilder appended with value and then ","</returns>
        protected StringBuilder appendValue<T>(StringBuilder _string, T value)
        {
            var formatString = "{0},";
            if (typeof(T) == typeof(string))
            {
                formatString = "'{0}',";
            }

            return _string.Append(string.Format(formatString, value));
        }
   


    }
}
