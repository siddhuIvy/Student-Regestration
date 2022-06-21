namespace Student_Regestration.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class student
    {
        public int id { get; set; }

        [StringLength(40)]
        public string name { get; set; }

        [StringLength(40)]
        public string Dept { get; set; }

        [StringLength(40)]
        public string city { get; set; }
    }
}
