using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetProjectBackEnd.Models
{
    public class LoginResponse
    {
        public string TokenString { get; set; }
        public long CustomerId { get; set; }
    }
}
