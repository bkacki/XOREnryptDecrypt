namespace XOREnryptDecrypt
{
    public class Program
    {
        static void Main(string[] args)
        {
            var message = "Lorem Ipsum.";
            var key = "test";
            var test = XorEncryptDecrypt.XorEnryptDecrypt(message, key);

            Console.WriteLine(test);
        }
    }
}
