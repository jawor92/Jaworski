using System;
using System.Collections.Generic;


namespace Jaworski.BL
{
    public class Client
    {
        public Client()
        {

        }

        public Client(int ClientID)
        {
            // "this" - the same name variable = argument, rel to prop
            this.ClientID = ClientID; //setter from argument, related to field below
        }
           
        //Properties
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


        //Methods
        public bool ValidateData()
        {
            var ProperVal = true;

            if (string.IsNullOrWhiteSpace(LastName))
                ProperVal = false;

            if (string.IsNullOrWhiteSpace(Email))
                ProperVal = false;

            return ProperVal;
        }
        /// <summary>
        /// This method will be saved Client
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code to saved defined Client
            return true;
        }
        /// <summary>
        /// This method will be download one, particluar Client data
        /// </summary>
        /// <param name="ClientID"></param>
        /// <returns></returns>
        public Client DownloadData(int ClientID)
        {
            // code to download ClientID data
            return new Client();
        }
        /// <summary>
        /// Download all Clients data
        /// </summary>
        /// <returns></returns>
        public List<Client> DownloadData()
        {
            //Code can download all Client data
            return new List<Client>();

        }
    }
}
