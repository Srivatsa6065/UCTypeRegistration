using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCTypeRegistration.AppCode
{
    public interface ITester
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Salary { get; set; }
    }

    public class Tester : ITester
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }
    }
}
