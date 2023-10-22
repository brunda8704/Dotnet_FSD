using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnClass
{
    public class DetailsOne
    {
        //acessing private fields from other class, create a method with class return type

        //int number1=30;
        //int number2=40;

        // for assigning values create a constructor
        int firstNumber;
        int secondNumber;

        public DetailsOne(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public DetailsTwo Display()
        {
            DetailsTwo detailsTwo = new DetailsTwo();
            detailsTwo.firstNumber = this.firstNumber;
            detailsTwo.secondNumber = this.secondNumber;
            return detailsTwo;
        }

    }
}
