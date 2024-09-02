using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOREnryptDecrypt
{
    public static class XorEncryptDecrypt
    {
        public static string Message { get; set; }
        public static string Key { get; set; }
        public static string EncryptedMessage { get; private set; }
        public static InputType MessageInputType { get; set; }
        public static InputType KeyInputType { get; set; }
        public static InputType EncryptedMessageInputType { get; set; }

        public static string BinaryEncryptedMessage => StringToBinary(EncryptedMessage);

        public static string XorEnryptDecrypt(string message, string key)
        {
            Message = message;
            Key = key;
            char[] _enryptedMessage = new char[Message.Length];

            for(int i=0; i < Message.Length; i++)
            {
                _enryptedMessage[i] = (char)(Message[i] ^ Key[i % Key.Length]);
            }

            EncryptedMessage = new string(_enryptedMessage);
            Message = new string(_enryptedMessage);
            return Message;
        }

        public static string XorEnryptDecrypt(string message, string key, InputType messageInput, InputType keyInput, InputType encryptedMessageInput)
        {
            if ((messageInput == InputType.binary && !IsBinary(message)) || (keyInput == InputType.binary && !IsBinary(key)))
                return "Error";

            Message = message;
            Key = key;
            int[] _enryptedMessage = new int[Message.Length];

            for (int i = 0; i < Message.Length; i++)
            {
                _enryptedMessage[i] = (byte)(Message[i] ^ Key[i % Key.Length]);
            }

            EncryptedMessage = String.Join("", _enryptedMessage);
            if (encryptedMessageInput == InputType.binary)
                return EncryptedMessage;
            else
                return EncryptedMessage;
        }

        private static bool IsBinary(string input) => input.All(c => c == '0' || c == '1');

        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        public static string InsertSpacesEvery8Chars(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (i > 0 && i % 8 == 0)
                {
                    sb.Append(' ');
                }
                sb.Append(input[i]);
            }
            return sb.ToString();
        }
    }
}
