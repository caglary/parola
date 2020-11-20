﻿using Newtonsoft.Json;
using System.Collections.Generic;
namespace parola
{
    public static class JsonOperation
    {
        public static string JsonSerialize<T>(IList<T> liste)
        {
            return JsonConvert.SerializeObject(liste);
        }
        public static List<T> JsonDeserialize<T>(string seralized)
        {
            return JsonConvert.DeserializeObject<List<T>>(seralized);
           
        }
    }
}