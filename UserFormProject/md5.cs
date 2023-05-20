using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace UserFormProject
{
   class md5
   {

    public static string HashPassword(string password)
    { 
      MD5 md5 = MD5.Create();
      byte[] b = Encoding.ASCII.GetBytes(password);
      byte[] result = md5.ComputeHash(b);

      StringBuilder stringBuilder = new StringBuilder();

      foreach (var item in result)
      {
        stringBuilder.Append(item.ToString("X2"));
      }

      return stringBuilder.ToString();
    }
   }
}
