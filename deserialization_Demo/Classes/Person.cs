using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deserialization_Demo.Classes
{
    [Serializable]
    public class Person
    {
        private string message = "I am a person!";

        public string GetText()
        {
            return message;
        }
    }
}
