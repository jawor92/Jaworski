using System.Collections.Generic;

namespace Jaworski.BL
{
    public class ClientRepository
    {
        //Methods
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
            // Client instance creation

            Client Client = new Client(ClientID);
            
            // code to download ClientID data
            //temporary hardcoded values to return Client
            if (ClientID == 1)
            {
                Client.Email = "test@test.gmail.com";
                Client.Name = "Mateusz";
                Client.LastName = "Jaworski";
            }

            return Client;
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
