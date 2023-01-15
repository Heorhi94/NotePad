using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Lab5_6
{
    internal class Files
    {
        public void WriteFile(string name, string text)
        {
            using (StreamWriter write = new StreamWriter(name))
            {
                write.WriteLine(text);
                MessageBox.Show("Text " + text + " ,write in the file " + name);
            }
        }

        public string ReadFile(string name)
        {
            using (StreamReader read = new StreamReader(name, true))
            {
                return read.ReadToEnd();
            }
        }


        public void ComprFile(string path)
        {
            using (FileStream file = new FileStream(path, FileMode.Open))
            {
                using (var compressedFileStream = file)
                {
                    using (var compressor = new DeflateStream(compressedFileStream, CompressionMode.Compress))
                    {
                        file.CopyTo(compressor);
                        file.SetLength(0);
                    }
                }
            }         
        }

        public void DecompressFile(string path)
        {
            using (FileStream file = new FileStream(path, FileMode.Open))
            {              
                using (var decompressor = new DeflateStream(file, CompressionMode.Decompress))
                { 
                    using(var memory = new MemoryStream())
                    {
                        decompressor.CopyTo(memory);
                        file.SetLength(0);
                        memory.Position = 0;
                        memory.CopyTo(file);
                    }                 
                }               
            }
        }
        public void ResultCompr(string path)
        {
            long origSize = new FileInfo(path).Length;
            long sizeCompress = new FileInfo(path).Length;           
            MessageBox.Show($"The original file weighs {origSize} bytes. " +
                $"Compress file {sizeCompress}.");
        }
        public void ResultDecompr(string path)
        {
            long origSize = new FileInfo(path).Length;         
            long sizeDecompress = new FileInfo(path).Length;

            MessageBox.Show($"The original file weighs {origSize} bytes. " +
                $"Decompress file {sizeDecompress}.");
        }

        public void Encrypt(string path, string key)
        {
            string x;
            string z;
            using (StreamReader reader = new StreamReader(path))
            {
                x = reader.ReadToEnd();
            }
            using (StreamWriter writer = new StreamWriter(path,false))
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                   rsa.FromXmlString(key);
                   z = Convert.ToBase64String(rsa.Encrypt(Encoding.UTF8.GetBytes(x), true));
                }
                writer.Write(z);
            }
            
        }
        public void Decrypt(string pathEnc, string key)
        {
            string x;
            string z;
            using (StreamReader reader = new StreamReader(pathEnc))
            {
                x = reader.ReadToEnd();
            }
            using (StreamWriter writer = new StreamWriter(pathEnc, false))
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(key);
                    z = Encoding.UTF8.GetString(rsa.Decrypt(Convert.FromBase64String(x), true));
                }
                writer.Write(z);
            }
        }
    }
}
