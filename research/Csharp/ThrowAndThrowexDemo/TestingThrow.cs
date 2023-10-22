using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowAndThrowexDemo
{
    internal class TestingThrow
    {
        public static void ExceptionMethod()
        {
            //try
            //{
            throw new Exception("Original Exception occurred in ExceptionMethod");
            //}
            //catch  (Exception e) {
            //    Console.WriteLine( e.Message);
            //}
        }
    }
}
