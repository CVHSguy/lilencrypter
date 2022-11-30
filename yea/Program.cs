using yea;

string password = "123hello";


string encrypter = pshand.Command($"ConvertTo-SecureString '{password}' -AsPlainText -Force | ConvertFrom-SecureString");
Console.WriteLine("encrypting the password: "+encrypter);


string decrypter = pshand.Command($"[Runtime.InteropServices.Marshal]::PtrToStringAuto([Runtime.InteropServices.Marshal]::SecureStringToBSTR($('{encrypter}'| ConvertTo-SecureString)))");
Console.WriteLine("decrypting the password: " +decrypter);