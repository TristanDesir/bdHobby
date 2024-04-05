using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class Hobby
    {
        private int no_hobby;
        private string hobbyDescription;

        public int No_hobby { get => no_hobby; set => no_hobby = value; }
        public string HobbyDescription { get => hobbyDescription; set => hobbyDescription = value; }
    }
}
