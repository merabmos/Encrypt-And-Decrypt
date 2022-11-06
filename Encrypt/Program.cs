//Encrypt
using Encrypt.Helper;

EncryptHelper EncryptProcedures = new EncryptHelper();
DecryptHelper DecryptProcedures = new DecryptHelper();
string EncryptVar = "Okay Very Good";
int key = 2;

var EncryptedString = EncryptProcedures.EncryptMethod(EncryptVar, key);

Console.WriteLine(EncryptedString);

var DecryptSplitText = DecryptProcedures.DecryptEncryptedText(EncryptedString, key);

Console.WriteLine(DecryptSplitText);



