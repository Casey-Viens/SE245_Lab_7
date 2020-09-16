using Lab5_CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lab5_CV
{
    public class PersonV2: Person
    {
        private string cellPhone;
        private string instagramURL;

        public string CellPhone
        {
            get
            {
                return cellPhone;
            }
            set
            {
                //Removes all "-" from the data in contact.CellPhone
                string tempCellPhone = value.Replace("-", "");
                //Ensures the cell phone number is the right number of characters
                if (tempCellPhone.Length == 10 && tempCellPhone.All(char.IsDigit))
                {
                    cellPhone = tempCellPhone;
                }
                else
                {
                    Feedback += "\nError: The cell phone number needs to be 10 digits.";
                }
            }
        }
        public string InstagramURL
        {
            get
            {
                return instagramURL;
            }
            set
            {
                if(value.Contains("instagram.com/"))
                {
                    instagramURL = value;
                }
                else
                {
                    Feedback += "\nError: The link does not lead to instagram.com";
                }
            }
        }
        public string AddARecord()
        {
            string strResult = "";

            //Make a connection object
            SqlConnection Conn = new SqlConnection();

            //Initialize it's properties
            Conn.ConnectionString = @GetConnected();

            string strSQL = "INSERT INTO Persons (FirstName, MiddleName, LastName, Street1, Street2, City, State, Zip, Phone, Email, CellPhone, InstagramURL) VALUES (@FirstName, @MiddleName, @LastName, @Street1, @Street2, @City, @State, @Zip, @Phone, @Email, @CellPhone, @InstagramURL)";
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;  
            comm.Connection = Conn;     
        
            comm.Parameters.AddWithValue("@FirstName", FirstName);
            comm.Parameters.AddWithValue("@MiddleName", MiddleName);
            comm.Parameters.AddWithValue("@LastName", LastName);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zip", Zip);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@CellPhone", CellPhone);
            comm.Parameters.AddWithValue("@InstagramURL", InstagramURL);


            //attempt to connect to the server
            try
            {
                Conn.Open();                                     
                int intRecs = comm.ExecuteNonQuery();
                strResult = $"SUCCESS: Inserted {intRecs} to Database";     
                Conn.Close();                           
            }
            catch (Exception err)                            
            {
                strResult = "ERROR: " + err.Message;             
            }
            finally
            {

            }

            return strResult;
        }

        public DataSet SearchPersons(String strFirstName, String strLastName)
        {
            //Create a dataset to return filled
            DataSet ds = new DataSet();


            SqlCommand comm = new SqlCommand();

            //Write a Select Statement to perform Search
            String strSQL = "SELECT PersonID, FirstName, LastName FROM Persons WHERE 0=0";

            //If the First/Last Name is filled in include it as search criteria
            if (strFirstName.Length > 0)
            {
                strSQL += " AND FirstName LIKE @FirstName";
                comm.Parameters.AddWithValue("@FirstName", "%" + strFirstName + "%");
            }
            if (strLastName.Length > 0)
            {
                strSQL += " AND LastName LIKE @LastName";
                comm.Parameters.AddWithValue("@LastName", "%" + strLastName + "%");
            }

            SqlConnection conn = new SqlConnection();
            string strConn = @GetConnected();
            conn.ConnectionString = strConn;


            comm.Connection = conn;    
            comm.CommandText = strSQL;  

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;


            conn.Open();                
            da.Fill(ds, "Persons_Temp");   
            conn.Close();           

            //Return the data
            return ds;
        }

        public SqlDataReader FindOnePerson(int intPersonID)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            string strConn = GetConnected();

            string sqlString =
           "SELECT * FROM Persons WHERE PersonID = @PersonID;";

            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@PersonID", intPersonID);

            conn.Open();


            return comm.ExecuteReader();

        }

        //Utility function so that one string controls all SQL Server Login info
        private string GetConnected()
        {
            return "Server=sql.neit.edu,4500;Database=SE245_CViens;User Id=SE245_CViens;Password=008008773;";
        }

        //Constructor for the PersonV2 class using the Person Constructor as a base
        public PersonV2(): base()
        {
            cellPhone = "";
            instagramURL = "";
        }
    }
}
