using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subby {
    static class Universe {
        private static List<Person> _Inhabitants = new List<Person>();
        private static List<SuperHero> _SuperHeros = new List<SuperHero>();

        public static List<Person> Inhabitants {
            get { return _Inhabitants; }
            set { _Inhabitants = value; }
        }

        public static List<SuperHero> SuperHeros
        {
            get { return _SuperHeros; }
            set { _SuperHeros = value; }
        }
    }
}
