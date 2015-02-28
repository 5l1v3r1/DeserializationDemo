using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deserialization_Demo.Classes
{
    [Serializable]
    public class Admin : IDisposable
    {
        private string message = "Bow before me, for I am r00t!";

        public string GetText()
        {
            return message;
        }

        ~Admin()
        {
            Dispose();
        }

        public void Dispose()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Admin\Desktop\tmpObjects\pwnd.txt"))
            {
                file.WriteLine("Pwned by Dispose()!");
            }
        }
    }
}
