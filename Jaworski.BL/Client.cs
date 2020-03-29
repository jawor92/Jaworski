using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaworski.BL
{
    public class Client
    {
        public static int Counter { get; set; }

        private string _lastName;

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public int ClientID { get; private set; }
        
        public string NameLastName
        {
            get
            {
                string NameLastName = Name;

                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    if (!string.IsNullOrWhiteSpace(NameLastName))
                    {
                        NameLastName += ", ";

                    }

                    NameLastName += LastName;
                }

                return NameLastName;
            }
        }
    }
}
