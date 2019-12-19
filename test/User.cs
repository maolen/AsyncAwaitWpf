using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
    }
}
