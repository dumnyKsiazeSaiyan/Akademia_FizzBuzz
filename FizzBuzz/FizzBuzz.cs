﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        public string ReturnFizzBuzz(float value)
        {
            if ((value % 3 == 0) && (value % 5 == 0))
                return "FizzBuzz";

            if (value % 3 == 0)
                return "Fizz";

            if (value % 5 == 0)
                return "Buzz";

            return value.ToString();
        }
    }
}
