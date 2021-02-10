using System;
namespace Cison.Security.Encryption
{
    public static class ASCIIBasicEncryption
    {
        public static string Encrypt(string textToBeEncrypted){
            try
            {
                if(IsTextValidate(textToBeEncrypted)){
                
                    string textResult = "";
                    int lenghtText = textToBeEncrypted.Length - 1;

                    for(int i = 0; i <= lenghtText; i++){
                        textResult += ConvertASC.Asc(GetCaracter(i, textToBeEncrypted)) + "#";
                    }
                    return StractLastCaracter(textResult);
                }
                return textToBeEncrypted;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public static string Decrypt(string textToBeDecrypted){
            try
            {
                if(IsTextValidate(textToBeDecrypted)){
                
                    string[] listCaracter = textToBeDecrypted.Split('#');
                    
                    int valueConvertForInt;
                    string textResult = string.Empty;

                    foreach(var s in listCaracter){
                        int.TryParse(s, out valueConvertForInt);
                        textResult += ConvertCHR.Chr(valueConvertForInt);
                    }
                    return textResult;
                }
                return textToBeDecrypted;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        private static char GetCaracter(int index, string text){
            return char.Parse(text.Substring(index,1));
        }
        public static bool IsTextValidate(string value){
            if(string.IsNullOrWhiteSpace(value)){
                return false;
            }
            return true;
        }
        public static string StractLastCaracter(string text){
            return text.Substring(0,text.Length-1);
        }   
    }
}