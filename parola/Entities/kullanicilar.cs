namespace parola
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kullanicilar")]
    public partial class kullanicilar
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string isim { get; set; }

        [Required]
        [StringLength(50)]
        public string soyisim { get; set; }

        [Required]
        [StringLength(150)]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        public string kullaniciadi { get; set; }

        [Required]
        [StringLength(10)]
        public string parola { get; set; }

        public DateTime kayittarihi { get; set; }

        public DateTime ensongiristarih { get; set; }

        [StringLength(11)]
        public string tc { get; set; }

        [StringLength(50)]
        public string tbssifre { get; set; }
    }
}
