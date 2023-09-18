using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Domain
{
    public class Rental
    {
        public int RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime RentalExpiry { get; set; }
        public decimal TotalCost { get; set; }

        //One To Many Relationship
        public ICollection<Member> Members { get; set; }


        //Many To Many Relationship
        public IList<MovieRental> RentalMovies { get; set;}
    }
}
