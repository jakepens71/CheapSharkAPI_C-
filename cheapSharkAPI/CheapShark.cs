using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace cheapSharkAPI
{
    public class CheapShark
    {
        static string baseUrl = "http://www.cheapshark.com/api/1.0/";

        public CheapShark()
        {

        }

        /*
        *
        *Get list of stores from cheap shark
        */
        public string getStores()
        {
            string url = baseUrl + "stores";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream resStream = response.GetResponseStream();

            ReadStream readStream = new ReadStream();

            StringBuilder sb = readStream.returnResults(resStream);

            string result = sb.ToString();

            return result;
        }


    }
}
