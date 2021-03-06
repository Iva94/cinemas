//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CinemaApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Seat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seat()
        {
            this.ReservedSeats = new HashSet<ReservedSeat>();
        }
    
        public int SeatId { get; set; }

        [Display(Name = "Sala")]
        public int AuditoriumId { get; set; }

        [Display(Name = "Red")]
        public string Row { get; set; }

        [Display(Name = "Broj sjedi�ta")]
        public Nullable<decimal> Number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservedSeat> ReservedSeats { get; set; }
        public virtual Auditorium Auditorium { get; set; }
    }
}
