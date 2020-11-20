using System;
using System.Collections.Generic;
using System.Reflection;
namespace parola
{
    public class ReflectionSelenium
    {
        static string className = "parola.Selenium";
        public void InvokeMethod(string MetotName, string kullaniciAdi, string parola)
        {
            Type selenium = GetClass();
            object _selenium = Activator.CreateInstance(selenium);
            MethodInfo methodInfo = selenium.GetMethod(MetotName);
            if (methodInfo != null)
            {
                string[] parameters = new string[2];
                parameters[0] = kullaniciAdi;
                parameters[1] = parola;
                methodInfo.Invoke(_selenium, parameters);
            }
            else
                throw new Exception("Metot Bulunamadı.");
        }
        Type GetClass()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            return assembly.GetType(className);
        }
        public List<string> methodInfos()
        {
            List<string> liste = new List<string>();
            MethodInfo[] methodInfos = GetClass().GetMethods();
            for (int i = 0; i < methodInfos.Length; i++)
            {
                if (methodInfos[i].Name != "GetType" && methodInfos[i].Name != "GetHashCode" && methodInfos[i].Name != "Equals" && methodInfos[i].Name != "ToString")
                {
                    liste.Add(methodInfos[i].Name);
                }
            }
            return liste;
        }
        public bool classControl()
        {
            var Result = GetClass();
            if (Result != null)
                return true;
            return false;
        }
    }
}
