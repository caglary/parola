using parola.Entities.Abstract;
using System;

namespace parola.Entities.Concrete

{
    public  class Parola:IEntity
    {
      
        public string isim { get; set; }
       
        public string kullaniciadi { get; set; }
       
        public string parola_ { get; set; }
       
        public string aciklama { get; set; }
    
        public int parolaid { get; set; }
        public string SeleniumMethod { get; set; }

        public DateTime CreateTime { get; set; }


    }

   
}
