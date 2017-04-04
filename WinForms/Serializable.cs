using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections.Generic;
using Transport;


namespace WinForms
{
        public static class Serialization
        {
            private static readonly BinaryFormatter _formatter = new BinaryFormatter();

            public static void Serialize(string fileName, List<ITransport> file)
            {
                using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    _formatter.Serialize(fs, file);
                }
            }

            public static List<ITransport> Deserialize(string fileName)
            {
                using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    var file = (List<ITransport>)_formatter.Deserialize(fs);
                    return file;
                }
            }
        }
    }
