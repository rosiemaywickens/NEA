using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Logic
{
    public interface IHashing
    {
        string GenerateHash(string UpassWord, string Salt);

        string CreateSalt();
    }
}
