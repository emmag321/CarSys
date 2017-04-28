using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
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
        private DateTime myRetDate = System.DateTime.Today;

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

         
        //Method for reservation num
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

        //method to take in reservation 
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
            String strSQL = "INSERT INTO Reservations VALUES(" + this.reservation_id + ",'" + this.forename + "','" + this.surname + "','" + this.phoneNumber + "','" + this.address + "','" + myArrDate + "','" + myRetDate + "','"  + this.regPlate +"','" + this.status + "','" + myRetDate + "')";

            //Execute SQL Query
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close DB Connection
            conn.Close();

        }

        //This method will mark booking as 'D' for removed/deleted
        public static void cancelBooking(int reservationId)
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            
            //here needs to be fixed
            String strSQL = "UPDATE Reservations SET Status = 'D' WHERE Reservation_Id = '" + reservationId + "'";


            //Execute SQL Query
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close DB Connection
            conn.Close();

        }

        //Method to see if car is available for rent
        public static Boolean isCarAvailable(String regNum, DateTime DateFrom, DateTime DateTo)
        {
            Boolean available = true;

            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            //String strSQL = "SELECT * FROM  Reservations WHERE RegPlate = '" + regNum + "' AND (('" + myArrDate + "' BETWEEN arrivalDate AND returnDate) OR ('" + myRetDate + "' BETWEEN arrivalDate AND returnDate))";
            String strSQL = "SELECT regplate FROM Reservations WHERE status = 'B' AND (TO_DATE('" + DateFrom.ToString("dd/M/yyyy") + "', 'DD/MM/YYYY') >= arrivalDate OR TO_DATE('" + DateTo.ToString("dd/M/yyyy") + "', 'DD/MM/YYYY') <= returnDate)";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
                available = false;
            //Close DB connection
            conn.Close();

            return available;
        }

        //Method to bring up avail cars
        public static DataTable availableCars(DateTime DateFrom, DateTime DateTo)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Cars WHERE regplate NOT IN (SELECT regplate FROM Reservations WHERE status = 'B' AND (TO_DATE('" + DateFrom.ToString("dd/M/yyyy") + "', 'DD/MM/YYYY') >= arrivalDate OR TO_DATE('" + DateTo.ToString("dd/M/yyyy") + "', 'DD/MM/YYYY') <= returnDate)) and status ='A'";


            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet DS = new DataSet();
            da.Fill(DS, "cars");

            conn.Close();

            return DS.Tables["cars"];
        }


        //method to get data for datagrid for income analysis
        public static DataSet getReservations(DataSet ds, String strSrh)
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            string strSQL = "SELECT TO_CHAR(ARRIVALDATE, 'MON')AS Month, COUNT(Reservation_ID) AS Reservations FROM Reservations WHERE EXTRACT(YEAR FROM ARRIVALDATE) = '" + strSrh + "' GROUP BY TO_CHAR(ARRIVALDATE, 'MON') Union ALL SELECT 'Total', COUNT(Reservation_ID) FROM Reservations";
            OracleCommand cmd = new OracleCommand(strSQL, conn);  
 
            //Execute Query
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            //DataSet ds = new DataSet();
            da.Fill(ds, "Res");

            //Close DB connection
            conn.Close();

            return ds;
        }

        //method gets the available cars
        public static DataTable getAvailableReservations()
        {
            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Reservations WHERE status = 'B'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet DS = new DataSet();
            da.Fill(DS, "res");

            conn.Close();


            return DS.Tables["res"];
        }

        //method changes the car staus to 'C'
        public static DataTable getCollectedReservations()
        {
            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Reservations WHERE status = 'C'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet DS = new DataSet();
            da.Fill(DS, "res");

            conn.Close();


            return DS.Tables["res"];
        }

        //method marks car status as 'R' for returned 
        public static void carReturned(int reservationID, DateTime finalReturnDate)
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String retDate = finalReturnDate.ToString("dd/M/yyyy");

            //here needs to be fixed
            String strSQL = "UPDATE RESERVATIONS SET status = 'R', final_return_date = TO_DATE('" + retDate + "', 'DD/MM/YYYY') WHERE reservation_id = " + reservationID + "";

            //Execute SQL Query
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close DB Connection
            conn.Close();

        }

        //method changes cars staus to 'C' for collected
        public static void carCollected(int reservationID)
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //String retDate = finalReturnDate.ToString("dd/M/yyyy");

            //here needs to be fixed
            String strSQL = "UPDATE RESERVATIONS SET status = 'C' WHERE reservation_id = '" + reservationID + "'";

            //Execute SQL Query
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close DB Connection
            conn.Close();

        }

    }
}
