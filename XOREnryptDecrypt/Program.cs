namespace XOREnryptDecrypt
{
    public class Program
    {
        static void Main(string[] args)
        {
            var message = "ptaki lataja kluczem";
            var key = "haslo";
            var test = XorEncryptDecrypt.XorEnryptDecrypt(message, key);

            Console.WriteLine(test);
        }
    }
}
