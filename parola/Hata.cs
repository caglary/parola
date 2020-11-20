using System;
namespace parola
{
    public static class Hata
    {
        
        public static void tryCatch(Action Action)
        {
            try
            {
                Action.Invoke();
            }
            catch (Exception exception)
            {
                MessageBoxOperation.MessageBoxError(exception.Message);
                Logging(exception);
            }
        }
        public static void Logging(Exception exception)
        {
            try
            {
                //will code for loging
            }
            catch (Exception _exception)
            {
                MessageBoxOperation.MessageBoxError("Loglama Yapılamadı. "+_exception.Message);
            }
        }
    }
}
