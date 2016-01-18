using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;


namespace cheapSharkAPI
{
    class ReadStream
    {
        public ReadStream()
        {

        }


        public StringBuilder returnResults(Stream stream)
        {
            StreamReader objectReader = new StreamReader(stream);

            StringBuilder results = new StringBuilder();

            while(objectReader.Peek() >= 0)
            {
                results.AppendLine(objectReader.ReadLine());
            }
            return results;
        }

    }
}
