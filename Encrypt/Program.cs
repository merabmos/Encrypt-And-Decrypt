//Encrypt
using Encrypt.Helper;

EncryptHelper EncryptProcedures = new EncryptHelper();
DecryptHelper DecryptProcedures = new DecryptHelper();
string EncryptVar = "Cipher Programming - 101!";
int key = 3;

while (key <= EncryptVar.Length)
{

var EncryptedString = EncryptProcedures.EncryptMethod(EncryptVar, key);
Console.WriteLine(EncryptedString.Length);
Console.WriteLine(EncryptedString);
Console.WriteLine();
var DecryptSplitText = DecryptProcedures.DecryptEncryptedText(EncryptedString, key);
Console.WriteLine(DecryptSplitText);
Console.WriteLine("-----------------------------");
    key++;
}



