using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software
{
    class Car_Class
    {

        private char car_Class;
        private string description;
        private double rate;

        //3 argument constructor
        public Car_Class(char carClass, String description, Double rate)
        {
            this.car_Class = carClass;
            this.description = description;
            this.rate = rate;
        }


//This method 
public static DataTable getCarClasses()
{
   //connect to DB
   OracleConnection conn = new OracleConnection(DBConnect.oradb);
   conn.Open();



   //Define SQL Query
   String strSQL = "SELECT * FROM Car_Classes ORDER BY Class_Code";
   OracleCommand cmd = new OracleCommand(strSQL, conn);

   OracleDataAdapter da = new OracleDataAdapter(cmd);

   DataSet DS = new DataSet();
   da.Fill(DS, "CC");

   conn.Close();


   return DS.Tables["CC"];
}


   //This method will make sure that the same class isnt put in the database twice
   public static Boolean isExistingClass(String classCode)
{
   Boolean answer = false;

   //Connect to DB
   OracleConnection conn = new OracleConnection(DBConnect.oradb);
   conn.Open();

   //Define SQL Query
   string strSQL = "SELECT * FROM Car_Classes WHERE Class_Code = '" + classCode + "'";
   OracleCommand cmd = new OracleCommand(strSQL, conn);

   //Execute Query
   OracleDataReader dr = cmd.ExecuteReader();

   if (dr.Read())
       answer = true;
   //Close DB connection
   conn.Close();

   return answer;
}

//This will put the car class into the DB
public void regCarClass()
{
   //Connect to DB
   OracleConnection conn = new OracleConnection(DBConnect.oradb);
   conn.Open();

   //Define SQL Query
   String strSQL = "INSERT INTO Car_Classes VALUES('" + this.car_Class + "','" + this.description + "'," + this.rate + ")";

   //Execute SQL Query
   OracleCommand cmd = new OracleCommand(strSQL, conn);
   cmd.ExecuteNonQuery();

   //Close DB Connection
   conn.Close();
}


/********** setters *********/ //this part will access the varibles and change them directly
        public void setCarClass(Char carClass) { this.car_Class = carClass; }

        public void setDescription(String description) { this.description = description; }

        public void setRate(Double rate) { this.rate = rate; }

        /**********getters *********/ //this part will get the values of the varbiles

        public char getCarClass() { return car_Class; }

        public string getDescription() { return description; }

        public double getRate() { return rate; }
    }
}
