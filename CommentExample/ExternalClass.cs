using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentExample
{
    public class ExternalClass
    {
        public ExternalClass()
        {

        }

        /// <summary>
        /// This fine method will take an integer and a name and return both as a string.
        /// </summary>
        /// <param name="id">This is the integer with the name of ID.</param>
        /// <param name="name">This is a name.</param>
        /// <returns></returns>
        public string AFineMethod(int id, string name)
        {
            return $"{id.ToString()} { name}" ;
        }

        public string ANotSoFineMethod(int id, string name)
        {
            return $"{id.ToString()} { name}";
        }
    }
}
