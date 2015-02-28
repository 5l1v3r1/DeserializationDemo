using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace deserialization_Demo.Classes
{
    public class SerializationHelper
    {
        public static void SerializeToBinaryFile<T>(string filePath, T objectIn)
        {
            using (Stream fs = File.Open(filePath, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, objectIn);
            }
        }

        public static T DeserializeFromBinaryFile<T>(string filePath)
        {
            using (Stream fs = File.Open(filePath, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                return (T)bf.Deserialize(fs);
            }
        }
    }
}
