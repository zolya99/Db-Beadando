﻿using Oracle.ManagedDataAccess.Client;
using P001_Connection.Model.Manager.Interface;
using P001_Connection.Model.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001_Connection.Model.Manager
{
    
    class Manager : IInsert<Focista>, IInsertP<Poszt>, IInsertC<Csapat>,
                           IUpdate<Focista>, IUpdateP<Poszt>, IUpdateC<Csapat>,
                           IDelete<Focista>, IDeleteP<Poszt>, IDeleteC<Csapat>,
                           ISelect<Focista>, ISelectP<Poszt>, ISelectC<Csapat>, ISelectU<User>
    {

        private OracleConnection getConnection()
        {
            string connectionString = "Data Source=193.225.33.71;User Id=RZOFGX;Password=EKE2020";
            OracleConnection oracleConnection = new OracleConnection(connectionString);

            return oracleConnection;
        }

        public bool DeleteFocista(Focista record)
        {
            OracleConnection oracleConnection = getConnection();

            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.CommandType = System.Data.CommandType.Text;
            oracleCommand.CommandText = "DELETE FROM focista WHERE focista.id = :id";

            
            OracleParameter idParameter = new OracleParameter();
            idParameter.ParameterName = "id";
            idParameter.DbType = System.Data.DbType.Int32;
            idParameter.Direction = System.Data.ParameterDirection.Input;
            idParameter.Value = record.Id;
            oracleCommand.Parameters.Add(idParameter);

            oracleConnection.Open();
            oracleCommand.Connection = oracleConnection;
            int rows = oracleCommand.ExecuteNonQuery();

            oracleConnection.Close();

            return rows != 0;
        }

        public bool DeletePoszt(Poszt record)
        {
            OracleConnection oracleConnection = getConnection();

            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.CommandType = System.Data.CommandType.Text;
            oracleCommand.CommandText = "DELETE FROM Poszt WHERE poszt.id = :id"; 

            
            OracleParameter idParameter = new OracleParameter();
            idParameter.ParameterName = "id";
            idParameter.DbType = System.Data.DbType.Int32;
            idParameter.Direction = System.Data.ParameterDirection.Input;
            idParameter.Value = record.Id;
            oracleCommand.Parameters.Add(idParameter);

            oracleConnection.Open();
            oracleCommand.Connection = oracleConnection;
            int rows = oracleCommand.ExecuteNonQuery();

            oracleConnection.Close();

            return rows != 0;
        }

        public bool DeleteCsapat(Csapat record)
        {
            OracleConnection oracleConnection = getConnection();

            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.CommandType = System.Data.CommandType.Text;
            oracleCommand.CommandText = "DELETE FROM Csapat WHERE csapat.id = :id"; 

            
            OracleParameter idParameter = new OracleParameter();
            idParameter.ParameterName = "id";
            idParameter.DbType = System.Data.DbType.Int32;
            idParameter.Direction = System.Data.ParameterDirection.Input;
            idParameter.Value = record.Id;
            oracleCommand.Parameters.Add(idParameter);

            oracleConnection.Open();
            oracleCommand.Connection = oracleConnection;
            int rows = oracleCommand.ExecuteNonQuery();

            oracleConnection.Close();

            return rows != 0;
        }

        public List<Focista> GetListFocista()
        {
            OracleConnection oracleConnection = getConnection();

            OracleCommand command = new OracleCommand(); 
            command.CommandType = System.Data.CommandType.Text; 
            command.CommandText = "SELECT * FROM Focista"; 
            command.Connection = oracleConnection; 
            command.CommandTimeout = 0;
            oracleConnection.Open(); 

            List<Focista> records = new List<Focista>();
            OracleDataReader oracleDataReader = command.ExecuteReader(); 
            while (oracleDataReader.Read()) 
            {
                Focista temp = new Focista();
                temp.Id = int.Parse(oracleDataReader["id"].ToString());
                temp.Szuletesi_ev = int.Parse(oracleDataReader["szuletesi_ev"].ToString());
                temp.Vezeteknev = oracleDataReader["vezeteknev"].ToString();
                temp.Keresztnev = oracleDataReader["keresztnev"].ToString();

                records.Add(temp);
            }

            oracleConnection.Close();

            return records;
        }

        public List<Poszt> GetListPoszt()
        {
            OracleConnection oracleConnection = getConnection();

            OracleCommand command = new OracleCommand(); 
            command.CommandType = System.Data.CommandType.Text; 
            command.CommandText = "SELECT * FROM Poszt"; 
            command.Connection = oracleConnection; 
            command.CommandTimeout = 0;
            oracleConnection.Open(); 

            List<Poszt> records = new List<Poszt>();
            OracleDataReader oracleDataReader = command.ExecuteReader();  
            while (oracleDataReader.Read()) 
            {
                Poszt temp = new Poszt();
                temp.Id = int.Parse(oracleDataReader["id"].ToString());
                temp.Megnevezes = oracleDataReader["megnevezes"].ToString();

                records.Add(temp);
            }

            oracleConnection.Close();

            return records;
        }

        public List<Csapat> GetListCsapat()
        {
            OracleConnection oracleConnection = getConnection();

            OracleCommand command = new OracleCommand(); 
            command.CommandType = System.Data.CommandType.Text; 
            command.CommandText = "SELECT * FROM Csapat"; 
            command.Connection = oracleConnection; 
            command.CommandTimeout = 0;
            oracleConnection.Open(); 

            List<Csapat> records = new List<Csapat>();
            OracleDataReader oracleDataReader = command.ExecuteReader();
            while (oracleDataReader.Read()) 
            {
                Csapat temp = new Csapat();
                temp.Id = int.Parse(oracleDataReader["id"].ToString());
                temp.Nev = oracleDataReader["nev"].ToString();

                records.Add(temp);
            }

            oracleConnection.Close();

            return records;
        }

        public Focista GetOneFocista(Focista record)
        {
            OracleConnection oracleConnection = getConnection();

            OracleCommand command = new OracleCommand(); 
            command.CommandType = System.Data.CommandType.Text; 
            command.CommandText = "SELECT * FROM Focista WHERE id = :id"; 
            command.Connection = oracleConnection;  
            command.CommandTimeout = 0;
            oracleConnection.Open(); 

            
            OracleParameter idParameter = new OracleParameter();
            idParameter.ParameterName = "id";
            idParameter.DbType = System.Data.DbType.Int32;
            idParameter.Direction = System.Data.ParameterDirection.Input;
            idParameter.Value = record.Id;
            command.Parameters.Add(idParameter);



            Focista temp = null;
            OracleDataReader oracleDataReader = command.ExecuteReader();
            if (oracleDataReader.Read()) 
            {
                temp = new Focista();
                temp.Id = int.Parse(oracleDataReader["id"].ToString());
                temp.Szuletesi_ev = int.Parse(oracleDataReader["szuletesi_ev"].ToString());
                temp.Vezeteknev = oracleDataReader["vezeteknev"].ToString();
                temp.Keresztnev = oracleDataReader["keresztnev"].ToString();

            }

            oracleConnection.Close();

            return temp;
        }

        public Poszt GetOnePoszt(Poszt record)
        {
            OracleConnection oracleConnection = getConnection();

            OracleCommand command = new OracleCommand();  
            command.CommandType = System.Data.CommandType.Text; 
            command.CommandText = "SELECT * FROM Poszt WHERE id = :id"; 
            command.Connection = oracleConnection; 
            command.CommandTimeout = 0;
            oracleConnection.Open(); 

            
            OracleParameter idParameter = new OracleParameter();
            idParameter.ParameterName = "id";
            idParameter.DbType = System.Data.DbType.Int32;
            idParameter.Direction = System.Data.ParameterDirection.Input;
            idParameter.Value = record.Id;
            command.Parameters.Add(idParameter);

            Poszt temp = null;
            OracleDataReader oracleDataReader = command.ExecuteReader();
            if (oracleDataReader.Read()) 
            {
                temp = new Poszt();
                temp.Id = int.Parse(oracleDataReader["id"].ToString());
                temp.Megnevezes = oracleDataReader["megnevezes"].ToString();


            }

            oracleConnection.Close();

            return temp;
        }

        public Csapat GetOneCsapat(Csapat record)
        {
            OracleConnection oracleConnection = getConnection();

            OracleCommand command = new OracleCommand(); 
            command.CommandType = System.Data.CommandType.Text;  
            command.CommandText = "SELECT * FROM Csapat WHERE id = :id"; 
            command.Connection = oracleConnection; 
            command.CommandTimeout = 0;
            oracleConnection.Open(); 

            
            OracleParameter idParameter = new OracleParameter();
            idParameter.ParameterName = "id";
            idParameter.DbType = System.Data.DbType.Int32;
            idParameter.Direction = System.Data.ParameterDirection.Input;
            idParameter.Value = record.Id;
            command.Parameters.Add(idParameter);

            Csapat temp = null;
            OracleDataReader oracleDataReader = command.ExecuteReader();
            if (oracleDataReader.Read())
            {
                temp = new Csapat();
                temp.Id = int.Parse(oracleDataReader["id"].ToString());
                temp.Nev = oracleDataReader["nev"].ToString();
            }

            oracleConnection.Close();

            return temp;
        }

        
        public bool InsertFocista(Focista record)
        {
            OracleConnection oracleConnection = getConnection();

            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.CommandType = System.Data.CommandType.Text;
            oracleCommand.CommandText = "INSERT INTO Focista(id, szuletesi_ev, vezeteknev, keresztnev) VALUES (:id, :szuletesi_ev, :vezeteknev, :keresztnev)";

             
            OracleParameter idParameter = new OracleParameter();
            idParameter.ParameterName = "id";
            idParameter.DbType = System.Data.DbType.Int32;
            idParameter.Direction = System.Data.ParameterDirection.Input;
            idParameter.Value = record.Id;
            oracleCommand.Parameters.Add(idParameter);

            OracleParameter szuletesi_evParameter = new OracleParameter();
            szuletesi_evParameter.ParameterName = "szuletesi_ev";
            szuletesi_evParameter.DbType = System.Data.DbType.Int32;
            szuletesi_evParameter.Direction = System.Data.ParameterDirection.Input;
            szuletesi_evParameter.Value = record.Szuletesi_ev;
            oracleCommand.Parameters.Add(szuletesi_evParameter);

            OracleParameter vezeteknevParameter = new OracleParameter();
            vezeteknevParameter.ParameterName = "vezeteknev";
            vezeteknevParameter.DbType = System.Data.DbType.String;
            vezeteknevParameter.Direction = System.Data.ParameterDirection.Input;
            vezeteknevParameter.Value = record.Vezeteknev;
            oracleCommand.Parameters.Add(vezeteknevParameter);


            OracleParameter keresztnevParamater = new OracleParameter();
            keresztnevParamater.ParameterName = "keresztnev";
            keresztnevParamater.DbType = System.Data.DbType.String;
            keresztnevParamater.Direction = System.Data.ParameterDirection.Input;
            keresztnevParamater.Value = record.Keresztnev;
            oracleCommand.Parameters.Add(keresztnevParamater);



            oracleConnection.Open();
            oracleCommand.Connection = oracleConnection;
            int rows = oracleCommand.ExecuteNonQuery();

            oracleConnection.Close();

            return rows != 0;
        }

        public bool InsertPoszt(Poszt record)
        {
            OracleConnection oracleConnection = getConnection();

            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.CommandType = System.Data.CommandType.Text;
            oracleCommand.CommandText = "INSERT INTO Poszt(id, megnevezes) VALUES (:id, :megnevezes)";

            
            OracleParameter idParameter = new OracleParameter();
            idParameter.ParameterName = "id";
            idParameter.DbType = System.Data.DbType.Int32;
            idParameter.Direction = System.Data.ParameterDirection.Input;
            idParameter.Value = record.Id;
            oracleCommand.Parameters.Add(idParameter);

            OracleParameter megnevezesParameter = new OracleParameter();
            megnevezesParameter.ParameterName = "megnevezes";
            megnevezesParameter.DbType = System.Data.DbType.String;
            megnevezesParameter.Direction = System.Data.ParameterDirection.Input;
            megnevezesParameter.Value = record.Megnevezes;
            oracleCommand.Parameters.Add(megnevezesParameter);

            oracleConnection.Open();
            oracleCommand.Connection = oracleConnection;
            int rows = oracleCommand.ExecuteNonQuery();

            oracleConnection.Close();

            return rows != 0;
        }

        public bool InsertCsapat(Csapat record)
        {
            OracleConnection oracleConnection = getConnection();

            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.CommandType = System.Data.CommandType.Text;
            oracleCommand.CommandText = "INSERT INTO Csapat(id, nev) VALUES (:id, :nev)";

            
            OracleParameter idParameter = new OracleParameter();
            idParameter.ParameterName = "id";
            idParameter.DbType = System.Data.DbType.Int32;
            idParameter.Direction = System.Data.ParameterDirection.Input;
            idParameter.Value = record.Id;
            oracleCommand.Parameters.Add(idParameter);

            OracleParameter nevParameter = new OracleParameter();
            nevParameter.ParameterName = "nev";
            nevParameter.DbType = System.Data.DbType.String;
            nevParameter.Direction = System.Data.ParameterDirection.Input;
            nevParameter.Value = record.Nev;
            oracleCommand.Parameters.Add(nevParameter);

            oracleConnection.Open();
            oracleCommand.Connection = oracleConnection;
            int rows = oracleCommand.ExecuteNonQuery();

            oracleConnection.Close();

            return rows != 0;
        }


        public bool UpdateFocista(Focista record)
        {
            OracleConnection oracleConnection = getConnection();

            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.CommandType = System.Data.CommandType.Text;
            oracleCommand.CommandText = "UPDATE Focista SET szuletesi_ev = :szuletesi_ev, vezeteknev = :vezeteknev, keresztnev = :keresztnev WHERE id = :id"; 

            OracleParameter szuletesi_evParameter = new OracleParameter();
            szuletesi_evParameter.ParameterName = "szuletesi_ev";
            szuletesi_evParameter.DbType = System.Data.DbType.Int32;
            szuletesi_evParameter.Direction = System.Data.ParameterDirection.Input;
            szuletesi_evParameter.Value = record.Szuletesi_ev;
            oracleCommand.Parameters.Add(szuletesi_evParameter);

            OracleParameter vezeteknevParameter = new OracleParameter();
            vezeteknevParameter.ParameterName = "vezeteknev";
            vezeteknevParameter.DbType = System.Data.DbType.String;
            vezeteknevParameter.Direction = System.Data.ParameterDirection.Input;
            vezeteknevParameter.Value = record.Vezeteknev;
            oracleCommand.Parameters.Add(vezeteknevParameter);


            OracleParameter keresztnevParameter = new OracleParameter();
            keresztnevParameter.ParameterName = "keresztnev";
            keresztnevParameter.DbType = System.Data.DbType.String;
            keresztnevParameter.Direction = System.Data.ParameterDirection.Input;
            keresztnevParameter.Value = record.Keresztnev;
            oracleCommand.Parameters.Add(keresztnevParameter);


            
            OracleParameter idParameter = new OracleParameter();
            idParameter.ParameterName = "id";
            idParameter.DbType = System.Data.DbType.Int32;
            idParameter.Direction = System.Data.ParameterDirection.Input;
            idParameter.Value = record.Id;
            oracleCommand.Parameters.Add(idParameter);

            oracleConnection.Open();
            oracleCommand.Connection = oracleConnection;
            int rows = oracleCommand.ExecuteNonQuery();

            oracleConnection.Close();

            return rows != 0;
        }

        public bool UpdatePoszt(Poszt record)
        {
            OracleConnection oracleConnection = getConnection();

            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.CommandType = System.Data.CommandType.Text;
            oracleCommand.CommandText = "UPDATE Poszt SET megnevezes = :megnevezes WHERE id = :id"; 



            OracleParameter megnevezesParameter = new OracleParameter();
            megnevezesParameter.ParameterName = "megnevezes";
            megnevezesParameter.DbType = System.Data.DbType.String;
            megnevezesParameter.Direction = System.Data.ParameterDirection.Input;
            megnevezesParameter.Value = record.Megnevezes;
            oracleCommand.Parameters.Add(megnevezesParameter);

            OracleParameter idParameter = new OracleParameter();
            idParameter.ParameterName = "id";
            idParameter.DbType = System.Data.DbType.Int32;
            idParameter.Direction = System.Data.ParameterDirection.Input;
            idParameter.Value = record.Id;
            oracleCommand.Parameters.Add(idParameter);

            oracleConnection.Open();
            oracleCommand.Connection = oracleConnection;
            int rows = oracleCommand.ExecuteNonQuery();

            oracleConnection.Close();

            return rows != 0;


        }

        public bool UpdateCsapat(Csapat record)
        {
            OracleConnection oracleConnection = getConnection();

            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.CommandType = System.Data.CommandType.Text;
            oracleCommand.CommandText = "UPDATE Csapat SET nev = :nev WHERE id = :id";



            OracleParameter nevParameter = new OracleParameter();
            nevParameter.ParameterName = "nev";
            nevParameter.DbType = System.Data.DbType.String;
            nevParameter.Direction = System.Data.ParameterDirection.Input;
            nevParameter.Value = record.Nev;
            oracleCommand.Parameters.Add(nevParameter);

            OracleParameter idParameter = new OracleParameter();
            idParameter.ParameterName = "id";
            idParameter.DbType = System.Data.DbType.Int32;
            idParameter.Direction = System.Data.ParameterDirection.Input;
            idParameter.Value = record.Id;
            oracleCommand.Parameters.Add(idParameter);

            oracleConnection.Open();
            oracleCommand.Connection = oracleConnection;
            int rows = oracleCommand.ExecuteNonQuery();

            oracleConnection.Close();

            return rows != 0;

        }

        public List<User> UserReadAll()
        {
            OracleConnection oracleConnection = getConnection();

            OracleCommand command = new OracleCommand(); 
            command.CommandType = System.Data.CommandType.Text; 
            command.CommandText = "SELECT * FROM Users"; 
            command.Connection = oracleConnection; 
            command.CommandTimeout = 0;
            oracleConnection.Open();


            List<User> records = new List<User>();
            OracleDataReader oracleDataReader = command.ExecuteReader(); 
            while (oracleDataReader.Read())
            {
                User temp = new User();
                temp.Id = int.Parse(oracleDataReader["id"].ToString());
                temp.Felhasznalonev = oracleDataReader["felhasznalonev"].ToString();
                temp.Jelszo = oracleDataReader["jelszo"].ToString();

                records.Add(temp);
            }

            oracleConnection.Close();

            return records;
        }

        public User CheckUsername(User record)
        {
            OracleConnection oracleConnection = getConnection();

            OracleCommand command = new OracleCommand(); 
            command.CommandType = System.Data.CommandType.Text;  
            command.CommandText = "SELECT * FROM Users where id = :id";
            command.Connection = oracleConnection; 
            command.CommandTimeout = 0;
            oracleConnection.Open();

            OracleParameter idParameter = new OracleParameter();
            idParameter.ParameterName = "id";
            idParameter.DbType = System.Data.DbType.Int32;
            idParameter.Direction = System.Data.ParameterDirection.Input;
            idParameter.Value = record.Id;
            command.Parameters.Add(idParameter);

            User temp = null;
            OracleDataReader oracleDataReader = command.ExecuteReader();
            if (oracleDataReader.Read())
            {
                temp = new User();
                temp.Id = int.Parse(oracleDataReader["id"].ToString());
                temp.Felhasznalonev = (oracleDataReader["felhasznalonev"].ToString());
                temp.Jelszo = oracleDataReader["jelszo"].ToString();

            }

            oracleConnection.Close();

            return temp;

        }

        public User AddLog(User record)
        {
            OracleConnection oracleConnection = getConnection();

            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.CommandType = System.Data.CommandType.Text;
            oracleCommand.CommandText = "INSERT INTO User_logs(id, bejelentkezes) VALUES (:id, :bejelentkezes)"; 

            
            OracleParameter idParameter = new OracleParameter();
            idParameter.ParameterName = "id";
            idParameter.DbType = System.Data.DbType.Int32;
            idParameter.Direction = System.Data.ParameterDirection.Input;
            idParameter.Value = record.Id;
            oracleCommand.Parameters.Add(idParameter);

            oracleConnection.Open();
            oracleCommand.Connection = oracleConnection;
            int rows = oracleCommand.ExecuteNonQuery();

            oracleConnection.Close();

            return record;
        }
    }
}
