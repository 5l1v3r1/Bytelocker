# Bytelocker

This program is a basic Windows ransomeware similar to cryptolocker which uses AES-256 with a local password. This program was created and must be used for educational purposes only. There is **no built-in payment system**.

![](https://github.com/xp4xbox/Bytelocker/blob/master/img.png)

### Instructions for making program encrypt a single folder
 * Open `src/Bytelocker.cs` in VS or any other editor/ide.
 * Enter folder to encrypt in the appropriate spot in the `Encrypt()` method. eg. 
 
 ```
 CryptoManagerMainHandler cmh = new CryptoManagerMainHandler();
 cmh.EncryptFolder(@"c:\temp");
 ```
 
### Instructions for making the program encrypt all drives
  * Open `src/CryptoManager/CryptoManagerMainHandler.cs` in VS or any other editor/ide.
  * Uncomment `//dfm.ChooseDir(subDir);` and `//dfm.EncryptDir();` in `EncryptAll()` method.
  * Go to `src/Bytelocker.cs`.
  * Replace `cmh.EncryptFolder(@"TEST_FOLDER_HERE");` in the `Encrypt()` method with `cmh.EncryptAll();`.
  
### Instructions for decrypt
  * Open regedit.
  * Navigate to `HKCU/Software/Bytelocker`.
  * Copy the value under the name of `id`.
  * Go to https://www.base64decode.org/ and convert the id from b64 to text to get the password.
  

> NOTE: The `Melt()` function which moves itself to the appdata dir, renames itself, and adds itself to startup may be detected by AV. To remove the `Melt()` function go to `src/Bytelocker.cs` and comment out the two `new Melt();` lines.
