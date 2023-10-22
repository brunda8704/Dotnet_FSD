using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumberException
{
    
        public class OddNumberException : Exception
        {
            //Overriding the Message property
            public override string Message
            {
                get
                {
                    return "Divisor Cannot be Odd Number";
                }
            }

            //Overriding the HelpLink Property
            public override string HelpLink
            {
                get
                {
                    return "Get More Information from here: https://dotnettutorials.net/lesson/create-custom-exception-csharp/";
                }
            }
        }

}

