using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software
{
    class Reservations
    {
        //attributes 
        private int reservation_id;
        private string forename;
        private string surname;
        private string phoneNumber;
        private string address;
        private DateTime arrivalDate;
        private DateTime returnDate;
        private string regPlate;
        private Char status;

        //constructor method with 2 args
        public Reservations(DateTime arrivalDate, DateTime returnDate)
        {
              this.arrivalDate = arrivalDate;
              this.returnDate = returnDate;
        }

        public Reservations(int reservation_id, string forename, string surname, string phoneNumber, string address, DateTime arrivalDate, DateTime returnDate, string regPlate, Char status)
        {
            this.reservation_id = reservation_id;
            this.forename = forename;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.arrivalDate = arrivalDate;
            this.returnDate = returnDate;
            this.regPlate = regPlate;
            this.status = status;

        }

        //Setters
        public void setArrivalDate(DateTime arrivalDate) { this.arrivalDate = arrivalDate; }

        public void setReturnDate(DateTime returnDate) { this.returnDate = returnDate; }

        public void setStatus(Char status) { this.status = status; }

        //Getters
        public DateTime getArrivalDate() { return arrivalDate; }

        public DateTime getReturnDate() { return returnDate; }

        public Char getStatus() { return status; }

        //load reservations
        /*public static int getNextReservationId()
        {
            int nextReservationNo;

            // Open the DB connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String selectMaxStmt = "SELECT MAX(reservation_id) FROM Reservations";

            OracleCommand cmd = new OracleCommand(selectMaxStmt, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            // Read the first (only) value returned from the query
            // If first stockNo, assign value of 1, otherwise add 1
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextReservationNo = 1;
            }
            else
            {
                nextReservationNo = Convert.ToInt32(dr.GetValue(0)) + 1;
            }

            // Close Database
            conn.Close();


            return nextReservationNo;
        }*/
        public static int nextReservationNo()
        {
            // variable to hold value to be returned
            int nextReservationNo;
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            //Define SQL query to get MAX stock_No used
            String strSQL = "SELECT MAX(RESERVATION_ID) FROM RESERVATIONS";
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();
            //read the first (only) value returned by query
            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            dr.Read();
            if (dr.IsDBNull(0))
                nextReservationNo = 1;
            else
                nextReservationNo = Convert.ToInt16(dr.GetValue(0)) + 1;
            //close DB connection
            myConn.Close();
            //return next StockNo
            return nextReservationNo;
        }

        public void regRes()
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String myArrDate = String.Format("{0:dd-MMM-yy}", arrivalDate);
            String myRetDate = String.Format("{0:dd-MMM-yy}", returnDate);

            //Define SQL Query
            //int reservation_id, string forename, string surname, string phoneNumber, string address, Char status
            //String strSQL = "INSERT INTO Reservations("reservation_id + ",'" + this.forename + "','" + this.surname + "','" + this.phoneNumber + "','" + this.address + "'," + " ")";
            String strSQL = "INSERT INTO Reservations VALUES(" + this.reservation_id + ",'" + this.surname + "','" + this.forename + "','" + this.phoneNumber + "','" + this.address + "','" + myArrDate + "','" + myRetDate + "','"  + this.regPlate +"','" + status + "')";

            //Execute SQL Query
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close DB Connection
            conn.Close();

        }
    }
}
