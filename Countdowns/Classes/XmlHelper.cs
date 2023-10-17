using System.Xml.Serialization;

namespace Countdowns.Classes
{
    internal static class XmlHelper
    {
        public static bool SerializeAndSave(string filename, object objectToSerialize)
        {
            XmlSerializer serializer = new XmlSerializer(objectToSerialize.GetType());
            try
            {
                using (FileStream stream = new FileStream(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), filename), FileMode.Create))
                    serializer.Serialize(stream, objectToSerialize);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static T LoadAndDeserialize<T>(this string filename)
        {
            if (!File.Exists(filename))
                throw new Exception("File not exist");

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            try
            {
                using (FileStream stream = new FileStream(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), filename), FileMode.Open))
                    return (T)serializer.Deserialize(stream);
            }
            catch
            {
                throw new Exception("Error during deserializing");
            }
        }
    }
}