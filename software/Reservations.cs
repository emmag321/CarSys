using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software
{
    class Reservations
    {

        private DateTime arrivalDate;
        private DateTime returnDate;

        public Reservations(DateTime arrivalDate, DateTime returnDate)
        {
              this.arrivalDate = arrivalDate;
              this.returnDate = returnDate;
           
        }
        
        //Setters
        public void setArrivalDate(DateTime arrivalDate) { this.arrivalDate = arrivalDate; }

        public void setReturnDate(DateTime returnDate) { this.returnDate = returnDate; }

        //Getters
        
    }
}
