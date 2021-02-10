using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccesResutl:Result
    {
        public SuccesResutl(string message):base(true,message)//Base, classı işaret eder.
        {

        }

        public SuccesResutl():base(true)
        {

        }
    }
}
