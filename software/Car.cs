﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software
{
    class Car
    {
        //declaring variables here
        private string regPlate;
        private char carClass;
        private char FuelType;
        private int numDoors;
        private string make;
        private string model;
        private char status;

        // Constructor with no arguments 
        public Car()
        {
            this.regPlate = "";
            this.carClass = 'U';
            this.FuelType = 'U';
            this.numDoors = 0;
            this.make = "";
            this.model = "";
            this.status = 'U';
        }

        //7 argument constructor
        public Car(String regPlate, Char carClass, Char fuelType, int noDoors, String makes, String model, Char status)
        {
            this.regPlate = regPlate;
            this.carClass = carClass;
            this.FuelType = fuelType;
            this.numDoors = noDoors;
            this.make = makes;
            this.model = model;
            this.status = status;
        }

        public void regAddCar()
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //here needs to be fixed
            String strSQL = "INSERT INTO Cars VALUES('" + this.regPlate + "','" + this.carClass + 
                "','" + this.FuelType + "'," + this.numDoors + ",'" + this.make + "','" + this.model + "','A')";

            alreadyRegistered(getRegPlate());

            //Execute SQL Query
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close DB Connection
            conn.Close();

        }

        public void getCarDetails(String RegPlate)
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Cars WHERE RegPlate = '" + RegPlate + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr= cmd.ExecuteReader();

            //does car exist
            if(dr.Read())
            {
                this.regPlate = dr.GetString(0);
                this.carClass = Convert.ToChar(dr.GetString(1).Substring(0,1));
                this.FuelType = Convert.ToChar(dr.GetString(2).Substring(0, 1));
                this.numDoors = Convert.ToInt32(dr.GetValue(3));
                this.make = dr.GetString(4);
                this.model = dr.GetString(5);
                this.status = dr.GetString(6).ToCharArray()[0];
            }

            // close DB
            conn.Close();

        }

        public static DataTable getSingleCar(String RegPlate)
        {
            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Cars WHERE RegPlate = '" + RegPlate + "'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet DS = new DataSet();
            da.Fill(DS, "car");

            conn.Close();


            return DS.Tables["car"];

        }

        public static DataTable getAllCars()
        {
            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * CARS'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet DS = new DataSet();
            da.Fill(DS, "car");

            conn.Close();


            return DS.Tables["car"];

        }

        public static Boolean alreadyRegistered(String RegNum)
        {
            Boolean answer = false;

            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Cars WHERE RegPlate = '" + RegNum + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
                answer = true;
            //Close DB connection
            conn.Close();

            return answer;

        }
        //This method will delete cars 
        public static void deleteCars(String RegPlate)
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //here needs to be fixed
            String strSQL = "UPDATE Cars SET Status = 'D' WHERE RegPlate = '" + RegPlate + "'";

            //Execute SQL Query
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close DB Connection
            conn.Close();

        }

        //Method updates the cars details into DB
        public void updateCars(String RegPlate)
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();


            //here needs to be fixed
            String strSQL = "UPDATE Cars SET regplate = '" + this.regPlate + "', carclass = '" + this.carClass +
                "', fueltype = '" + this.FuelType + "', nodoors = " + this.numDoors + ", make = '" + this.make + "', model = '" + this.model + "', status = '" + this.status + "' WHERE regplate = '" + RegPlate + "'";


            //Execute SQL Query
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close DB Connection
            conn.Close();

        }

        //Retrieves all cars details from DB 
        public static DataTable getCars()
        {
            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Cars";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet DS = new DataSet();
            da.Fill(DS, "cars");

            conn.Close();


            return DS.Tables["cars"];
        }


        //Retrieves available cars details from DB 
        public static DataTable getAvailableCars2(DateTime DateFrom, DateTime DateTo)
        {
            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Cars WHERE status = 'A'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet DS = new DataSet();
            da.Fill(DS, "cars");

            conn.Close();

            return DS.Tables["cars"];
        }

        //Retrieves available cars details from DB 
        public static DataTable getAvailableCars()
        {
            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Cars WHERE status = 'A'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet DS = new DataSet();
            da.Fill(DS, "cars");

            conn.Close();

            return DS.Tables["cars"];
        }

        //Retrieves removed cars details from DB 
        public static DataTable getRemovedCars()
        {
            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Cars WHERE status = 'D'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet DS = new DataSet();
            da.Fill(DS, "cars");

            conn.Close();

            return DS.Tables["cars"];
        }

        //method for analysis to group by make
        public static DataTable carAnalysis ()
        {
            //SELECT make, COUNT(make)FROM Cars GROUP BY make;
            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT make, COUNT(make) AS num_cars  FROM Cars GROUP BY make";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet DS = new DataSet();
            da.Fill(DS, "cars");

            conn.Close();

            return DS.Tables["cars"];
        }

        public static DataTable carsByPopularity()
        {
            //SELECT make, COUNT(make)FROM Cars GROUP BY make;
            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT C.regplate, C.make, C.model,  COUNT(R.regplate) AS Num_Bookings FROM Cars C, Reservations R WHERE C.regplate = R.regplate GROUP BY C.regplate, C.make, C.model ORDER BY COUNT(R.regplate) DESC";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet DS = new DataSet();
            da.Fill(DS, "cars");

            conn.Close();

            return DS.Tables["cars"];
        }

        /********** setters *********/ //this part will access the varibles and change them directly


        public void setRegPlate(String regPlate) {this.regPlate = regPlate;}

        public void setCar_Class(Char car_Class) {this.carClass = car_Class;}

        public void setFuelType(Char fuelType) {this.FuelType = fuelType;}

        public void setNumDoors(int noDoor) {this.numDoors = noDoor;}

        public void setMake(String make) {this.make = make;}

        public void setModel(String model) {this.model = model;}

        public void setStatus(Char status) {this.status = status;}


        /**********getters *********/ //this part will get the values of the varbiles

        public String getRegPlate() { return regPlate;}

        public Char getCarClass() {return carClass;}

        public Char getFuelType() {return FuelType;}

        public int getNumDoors() {return numDoors;}

        public string getMake(){return make;}

        public string getModel() {return model;}

        public Char getStatus() {return status;}
    }
}




