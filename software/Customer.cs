using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software
{
    public class Customer
    {
        private int customer_id;
        private String surname;
        private String forename;
        private String phoneNum;
        private String address;

        public Customer (int customerId, String forename, String surname, String phoneNum, String address)
        {
            this.customer_id = customerId;
            this.forename = forename;
            this.surname = surname;
            this.phoneNum = phoneNum;
            this.address = address;
        }


        public Customer (String forename, String surname, String phoneNum, String address) : this(getNextCustomerId(), forename, surname, phoneNum, address) { }


        public static DataTable getCustomers()
        {
            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Customers";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet DS = new DataSet();
            da.Fill(DS, "custs");

            conn.Close();


            return DS.Tables["custs"];
        }

        public static DataTable getSingleCustomer(int customerId)
        {
            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Customers WHERE customer_id = " + customerId;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet DS = new DataSet();
            da.Fill(DS, "cust");

            conn.Close();


            return DS.Tables["cust"];
        }

        public static int getNextCustomerId()
        {
            int nextCustomerNo;

            // Open the DB connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String selectMaxStmt = "SELECT MAX(customer_id) FROM Customers";

            OracleCommand cmd = new OracleCommand(selectMaxStmt, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            // Read the first (only) value returned from the query
            // If first stockNo, assign value of 1, otherwise add 1
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextCustomerNo = 1;
            }
            else
            {
                nextCustomerNo = Convert.ToInt32(dr.GetValue(0)) + 1;
            }

            // Close Database
            conn.Close();


            return nextCustomerNo;
        }


        public void regCustomer()
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "INSERT INTO Customers (customer_id, forename, surname, phone_number, address) VALUES(" + customer_id + ",'" + forename + "', '" + surname + "', '" + phoneNum + "', '" + address + "')";

            //Execute SQL Query
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close DB Connection
            conn.Close();
        }

        public void updateCustomer()
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "UPDATE Customers SET forename = '" + forename + "', surname  = '" + surname + "', phone_number = '" + phoneNum + "', address = '" + address + "' WHERE customer_id = " + customer_id;

            //Execute SQL Query
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close DB Connection
            conn.Close();
        }


    }
}
