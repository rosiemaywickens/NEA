using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Security.Cryptography;

namespace WindowsFormsApp1.Logic
{
    public class Hashing : IHashing
    {
        public string GenerateHash(string UpassWord, string Salt)
        {
            string bow = UpassWord + Salt;
            byte[] bytechunks = Encoding.UTF8.GetBytes(bow);
            HashAlgorithm hashAlgorithm = HashAlgorithm.Create();
            byte[] result = hashAlgorithm.ComputeHash(bytechunks);
            string wordresult = Convert.ToBase64String(result);
            return wordresult;
        }



        public string CreateSalt()
        {
            int length = 32;
            byte[] chomps = new byte[length];
            Random r = new Random();
            for (int i = 0; i < length; i++)
            {

                int x = r.Next(65, 90);
                chomps[i] = (byte)x;


            }
            string salty = Encoding.ASCII.GetString(chomps);
            return salty;

            // testing   



        }

    }
}
