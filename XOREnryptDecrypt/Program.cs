namespace XOREnryptDecrypt
{
    public class Program
    {
        static void Main(string[] args)
        {
            var message = "10101";
            var key = "11111";
            var encryptedMessage = XorEncryptDecrypt.XorEnryptDecrypt(message, key, InputType.binary, InputType.binary, InputType.binary);
            var test = XorEncryptDecrypt.XorEnryptDecrypt(encryptedMessage, key, InputType.binary, InputType.binary, InputType.binary);

            Console.WriteLine($@"Message: {message}
Key: {key}
Encrypted Message: {encryptedMessage}
Reverse: {test}");
        }
    }
}
