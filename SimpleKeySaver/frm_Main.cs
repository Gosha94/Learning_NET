using SimpleKeySaver.Models;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SimpleKeySaver
{
    public partial class frm_Main : Form
    {
        BinaryFormatter formatter;
        bool toEncrypt;
        public frm_Main()
        {
            InitializeComponent();
            formatter = new BinaryFormatter();
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            SerializeObjectToFile(formatter);
            //WriteDeserializedObjectToTextBox("SERIALIZED AND ENCRYPTED!", formatter);
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {            
            DeserializeFileToObject(formatter);
        }
        private void SerializeObjectToFile(BinaryFormatter formatter)
        {
            Resource siteExample = new Resource()
            {
                ResourceName = "Google Mail",
                Link = "http://",
                Modified = DateTime.Now,
                Username = "Gosha",
                Password = "1234",
            };

            using (Stream serializer = File.Create("Test.txt"))
            {
                using (CryptoStream cryptStream = OpenAesStream(serializer, toEncrypt = true))
                {
                    formatter.Serialize(cryptStream, siteExample);
                }                
            }

            Debug.WriteLine("WriteEnd");
        }
        private void DeserializeFileToObject(BinaryFormatter formatter)
        {
            using (Stream deserializer = File.OpenRead("Test.txt"))
            {
                using (CryptoStream cryptStream = OpenAesStream(deserializer, toEncrypt = false))
                {
                    Resource deserializedObj = (Resource)formatter.Deserialize(cryptStream);
                    WriteDeserializedObjectToTextBox(deserializedObj);
                }                
            }
        }
        private void WriteDeserializedObjectToTextBox(Resource modelObj) 
        {
            string finalString;

            txtBx_Data.Clear();
            finalString =
            modelObj.ResourceName    + Environment.NewLine + 
            modelObj.Username       + Environment.NewLine + 
            modelObj.Password       + Environment.NewLine + 
            modelObj.Link           + Environment.NewLine + 
            modelObj.Modified;

            txtBx_Data.Text = finalString;
            
        }
        private CryptoStream OpenAesStream(Stream streamObj, bool isEncrypt) 
        {
            try
            {
                //Create a new instance of the default Aes implementation class  
                // and encrypt the stream.  
                Aes aes = Aes.Create();

                byte[] key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
                byte[] iv = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };

                if (isEncrypt)
                {
                    //Create a CryptoStream for encrypt, pass it the FileStream, and encrypt
                    //it with the Aes class.
                    CryptoStream cryptStreamEncrypt = new CryptoStream(streamObj, aes.CreateEncryptor(key, iv), CryptoStreamMode.Write);
                    Debug.WriteLine("The encrypted stream is opened. =)");
                    return cryptStreamEncrypt;                    
                }
                else
                {
                    //Create a CryptoStream for decrypt, pass it the file stream, and decrypt
                    //it with the Aes class using the key and IV.
                    CryptoStream cryptStreamDecrypt = new CryptoStream(streamObj, aes.CreateDecryptor(key, iv), CryptoStreamMode.Read);
                    Debug.WriteLine("The decrypted stream is opened. =)");
                    return cryptStreamDecrypt;                    
                }
                               
            }
            catch
            {
                //Inform the user that an exception was raised.  
                Debug.WriteLine("The encryption stream open failed. =(");
                return null;
                throw;                
            }
        }
    }
}
