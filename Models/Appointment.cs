using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using a.Models;

namespace a.Models
{
    public class Appointment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:s}")]
        public DateTime Date { get; set; }

        public int TimeslotID { get; set; }

        public int LocationID { get; set; }

        public bool IsBooked { get; set; }

        public Timeslot Timeslot { get; set; }

        public Location Location {get; set;}

    }
}
