using yea;

string password = "123hello";

Console.WriteLine("the password: "+password);
//encrypting the pw
string encrypter = pshand.Command($"ConvertTo-SecureString '{password}' -AsPlainText -Force | ConvertFrom-SecureString");
Console.WriteLine("encrypting the password: "+encrypter);

//decrypting the pw
string decrypter = pshand.Command($"[Runtime.InteropServices.Marshal]::PtrToStringAuto([Runtime.InteropServices.Marshal]::SecureStringToBSTR($('{encrypter}'| ConvertTo-SecureString)))");
Console.WriteLine("decrypting the password: " +decrypter);


//test on another pc hmmge
string testdecrypt = "01000000d08c9ddf0115d1118c7a00c04fc297eb01000000a501041762c61740b92dc3c33ff8579900000000020000000000106600000001000020000000814e5518a6e4e9ad97ab5f65421655c1e2bcad22fe01808bf28417fce983de6e000000000e80000000020000200000007ae3a5ea399974a325846612603b250d21bf8169eb63d868c9026be9da8cb1c42000000086c4bf52e1671c96399e2652422e4bcc3e01df0a7cccef7d1bf3c99e28e8ac734000000090ec217dc7983860cd629c68dda0614031e3e9cb4beda18e508e84680c936ee75e4a4948bf3b18283e71d2d010e85138be60440e92843db902e0c703c8194a1f";
string decrypter2 = pshand.Command($"[Runtime.InteropServices.Marshal]::PtrToStringAuto([Runtime.InteropServices.Marshal]::SecureStringToBSTR($('{testdecrypt}'| ConvertTo-SecureString)))");
Console.WriteLine("decrypting carls encrypted password :o : " + decrypter2);
