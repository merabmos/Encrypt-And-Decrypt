using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt.Helper
{
    public class EncryptHelper
    {
        private string[] SpliterText(string DecryptVar, int key)
        {
            int alg = DecryptVar.Length % key == 0 ? DecryptVar.Length / key : DecryptVar.Length / key + 1;

            string[] splited = new string[alg];
            int j = 0;
            int temp = key;
            for (int i = 0; i < splited.Length; i++)
            {
                string text = "";
                while (j < temp)
                {
                    try
                    {
                        text += DecryptVar[j];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        text += "";
                    }

                    j++;
                }
                temp += key;
                splited[i] = text;
            }

            return splited;
        }

        public string EncryptMethod(string DecryptVar, int key)
        {
            var SplitedText = SpliterText(DecryptVar, key);
            List<string> EncryptedList = new List<string>();
            string text = "";
            int j = 0;
            for (int i = 0; i < SplitedText.Length; i++)
            {
                try
                {
                    text += SplitedText[i][j];
                }
                catch (IndexOutOfRangeException)
                {
                    text += "";
                }

                if (i == SplitedText.Length - 1)
                {
                    EncryptedList.Add(text);

                    j++;

                    if (EncryptedList.Count != SplitedText[0].Length)
                        i = -1;

                    text = string.Empty;
                }
            }
      
            return EncryptedListToString(EncryptedList);
        }

        private string EncryptedListToString(List<string> EncryptedList)
        {
            var text = "";

            foreach (var item in EncryptedList)
                text += item;

            return text;
        }
    }
}
