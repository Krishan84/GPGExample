using GPGExample.Utility;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPGExample.GPG
{
    public static  class Encryption
    {

        private static PgpPrivateKey FindSecretKey(PgpSecretKeyRingBundle pgpSec, long keyId, char[] pass)
        {
            PgpSecretKey pgpSecKey = pgpSec.GetSecretKey(keyId);
            if (pgpSecKey == null)
            {
                return null;
            }

            return pgpSecKey.ExtractPrivateKey(pass);
        }
        public static bool Encrypt(string inputfile,string outputfile,string publickeypath)
        {
            bool success = false;
            Stream outputstream=File.Create(outputfile + "\\" + "Encrypted" + Path.GetFileName(inputfile));
            success = Encrypt(inputfile, outputstream, IOHelper.GetStreamFromFilePath(publickeypath),true,true);
           return success;
        }
        private static PgpPublicKey ReadPublicKey(Stream inputStream)
        {
            inputStream = PgpUtilities.GetDecoderStream(inputStream);
            PgpPublicKeyRingBundle pgpPub = new PgpPublicKeyRingBundle(inputStream);

            foreach (PgpPublicKeyRing keyRing in pgpPub.GetKeyRings())
            {
                foreach (PgpPublicKey key in keyRing.GetPublicKeys())
                {
                    if (key.IsEncryptionKey)
                    {
                        return key;
                    }
                }
            }

            throw new ArgumentException("Can't find encryption key in key ring.");
        }
        public static bool Encrypt(string inputfile,Stream outputFile,Stream publickeypath,bool armor,bool withIntegrityCheck)
        {
            bool success = false;
            try
            {
                PgpPublicKey pubKey = ReadPublicKey(publickeypath);
                MemoryStream outputBytes = new MemoryStream();
                PgpCompressedDataGenerator dataCompressor = new PgpCompressedDataGenerator(CompressionAlgorithmTag.Zip);
                PgpUtilities.WriteFileToLiteralData(dataCompressor.Open(outputBytes), PgpLiteralData.Binary, new FileInfo(inputfile));

                dataCompressor.Close();
                PgpEncryptedDataGenerator dataGenerator = new PgpEncryptedDataGenerator(SymmetricKeyAlgorithmTag.Cast5, withIntegrityCheck, new SecureRandom());

                dataGenerator.AddMethod(pubKey);
                byte[] dataBytes = outputBytes.ToArray();


                if (armor)
                {
                    using (ArmoredOutputStream armoredStream = new ArmoredOutputStream(outputFile))
                    {
                        IOHelper.WriteStream(dataGenerator.Open(armoredStream, dataBytes.Length), ref dataBytes);
                    }
                }
                else
                {
                    IOHelper.WriteStream(dataGenerator.Open(outputFile, dataBytes.Length), ref dataBytes);
                }
                dataGenerator.Close();
                success = true;
            }
            catch(Exception ex)
            {
                LastException = ex.Message;
            }

            return success;
        }

        public static string LastException { get; set; }
    }
}
