using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool succes,string message)
        {
            this.Succes = Succes;
            this.Message = Message;
        }

        public bool Succes { get; }

        public string Message { get; }
    }
}
