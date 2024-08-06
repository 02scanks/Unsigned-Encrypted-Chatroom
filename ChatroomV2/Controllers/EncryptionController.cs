using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class EncryptionController 
{

    internal static async Task<string> EncryptMessage(string message, byte[] key, byte[] iv)
    {
        try
        {
            // Encrypt the message on a separate thread
            return await Task.Run(() =>
            {
                using (var aes = Aes.Create())
                {
                    // Set the key and IV
                    aes.Key = key;
                    aes.IV = iv;

                    // Create an encryptor to perform the stream transform
                    var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    // Create the streams used for encryption
                    using (var ms = new MemoryStream())
                    {
                        using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            using (var sw = new StreamWriter(cs))
                            {
                                sw.Write(message);
                            }
                        }

                        return Convert.ToBase64String(ms.ToArray());
                    }

                }
            });


            
        }
        catch (Exception ex) 
        {
            MessageBox.Show($"An Error Occurred: {ex.Message}", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return string.Empty;
        
    }

    public static async Task<string> DecryptMessage(string encryptedMessage, byte[] key, byte[] iv)
    {
        try 
        {
            // Decrypt the message on a seperate thread
            return await Task.Run(() =>
            {
                // Convert the encrypted message to a byte array
                var buffer = Convert.FromBase64String(encryptedMessage);

                // Create a new instance of the Aes class
                using (var aes = Aes.Create())
                {
                    // Set the key and IV
                    aes.Key = key;
                    aes.IV = iv;

                    // Create a decryptor to perform the stream transform
                    var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    // Create the streams used for decryption
                    using (var ms = new MemoryStream(buffer))
                    {
                        using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            using (var sr = new StreamReader(cs))
                            {
                                return sr.ReadToEnd();
                            }
                        }
                    }
                }
            });
        }
        catch(Exception ex)
        {
            MessageBox.Show($"An Error Occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return string.Empty;
    }

    

}