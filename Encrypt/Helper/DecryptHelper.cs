using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt.Helper
{
    public class DecryptHelper
    {
        private List<string> SpliterText(string EncryptedText, int key)
        {
            List<string> vs = new List<string>();

            int columns = key;
            int saveEncryptedTextLength = EncryptedText.Length;
            int rows = (EncryptedText.Length / key) * key == EncryptedText.Length ? EncryptedText.Length / key : EncryptedText.Length / key + 1;
            for (int i = 0; i < columns; i++)
            {

                if (saveEncryptedTextLength % key == i && saveEncryptedTextLength % key != 0)
                {
                    rows--;
                }

                var text = "";
                for (int j = 0; j < rows; j++)
                {
                    text += EncryptedText[j];
                }

                vs.Add(text);
                EncryptedText = EncryptedText.Remove(0, rows);

            }
            return vs;
        }
        public string DecryptEncryptedText(string EncryptedText, int key)
        {
            var array = SpliterText(EncryptedText, key);
            int j = 0;
            string text = "";
            for (int i = 0; i < array.Count; i++)
            {
                try
                {
                    text += array[i][j];
                }
                catch (Exception)
                {
                    break;
                }
                if (i == array.Count - 1)
                {
                    j++;
                    i = -1;
                }
            }
            return text;
        }
    }

}
