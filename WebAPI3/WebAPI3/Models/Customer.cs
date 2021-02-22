using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI3.Models
{
    public class Customer
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int AccountBalance { get; }
    }
}
