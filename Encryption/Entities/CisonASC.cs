using System;
namespace Cison.Security.Encryption
{
    public class CisonASC : ClassBase
    {
        private string _value;
        public string Value { 
            get => _value; 
            set {_value = value; } 
        }
        public string Encrypt(){
            return GetEncrypt();   
        }
        private string GetEncrypt(){
            try
            {
                if(IsTextValidate(this.Value)){
                
                string textResult = "";
                int lenghtText = Value.Length - 1;

                for(int i = 0; i <= lenghtText; i++){
                    textResult +=ConvertASC.Asc(GetCaracter(i, Value)) + "#";
                }
                return StractLastCaracter(textResult);
                }
                return Value;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public string Decrypt(){
            return GetDecrypt();
        }
        private string GetDecrypt(){
            try
            {
                if(IsTextValidate(this.Value)){
                
                    string[] listCaracter = this.Value.Split('#');
                    
                    int valueConvertForInt;
                    string textResult = string.Empty;

                    foreach(var s in listCaracter){
                        int.TryParse(s, out valueConvertForInt);
                        textResult += ConvertCHR.Chr(valueConvertForInt);
                    }
                    return textResult;
                }
                return Value;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        private char GetCaracter(int index, string text){
            return char.Parse(text.Substring(index,1));
        }
    }
}