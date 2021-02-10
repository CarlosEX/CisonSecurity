
namespace Cison.Security.Encryption
{
    public abstract class ClassBase
    {
        public bool IsTextValidate(string value){
            if(string.IsNullOrWhiteSpace(value)){
                return false;
            }
            return true;
        }
        public string StractLastCaracter(string text){
            try
            {
                if(IsTextValidate(text)){
                    return text.Substring(0,text.Length-1);
                }
                return text;
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }   
    }
}