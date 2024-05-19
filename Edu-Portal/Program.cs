using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Configuration;
using System.Data.SqlClient;


namespace Edu_Portal
{
   public class Profile
    {
        //this class is made for basically validation of the variables only :>

        //the private properties AKA the values
        private string name;
        private string password;
        private string registration_number;
        private string email;
        private string grade;
        public bool is_student; 



        //these are the properties 
        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public string Name 
        {
            get { return name; }
            set { name = value.ToUpper(); }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }   
        public string RegistrationNumber
        {
            get { return registration_number; }
            set { 
                registration_number = value;
               
            
            
            }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        
        public Profile(string n, string p, string r, string e,string g, bool student )  //this is the first constructor that takes in the "sign up" information
        {
            grade = g;
            Name = n;
            Password = p;
            RegistrationNumber = r;
            Email = e;
            is_student = student;
        }
        public Profile(string r, string p)
        {
            RegistrationNumber = r;
            Password = p;
        }

    }

    class Authenticate:Profile
    {

        public Authenticate(string n, string p,string r,string e,string g, bool student):base(n, p, r, e, g ,student) { } //this is the first constructor that we are going to call in the sign up part

        public Authenticate(string r, string p) : base(r, p) { } //this will be the constructor for the login page

        
        public bool student(string Reg)
        {
            if (Reg[0]== '2')
            {
                return true;
            }
            else if (Reg[0] == '3')
            {
                return false;
            }
            return false;
        }
       
        public string sign_up()
        {

            string placeholder;
           

            if (is_student)
            {
                placeholder = "Student_Personal_Info";
            }
            else
            {
                placeholder = "Teacher_Personal_Information";
            }


            try {

                var connectionString = ConfigurationManager.ConnectionStrings["EduPortalDB"].ConnectionString;
      
                using (SqlConnection connection = new SqlConnection(connectionString)) //basically use this object within this scope
                {

                    connection.Open();

                   //the SQL query n the SQL command to check if this user already exists or not.
                    string validation_query = $"SELECT COUNT(*) FROM {placeholder} WHERE Registration_Number = @RegistrationNumber";
                    SqlCommand validation = new SqlCommand(validation_query, connection);
                    validation.Parameters.AddWithValue("@RegistrationNumber", RegistrationNumber);


                    var dr = validation.ExecuteScalar();
                    //this returns the num of rows with sum val


                    //i found this on the internet and added cuz "dr" returns null sometimes and i dont want that -j
                    int count = (dr != null) ? Convert.ToInt32(dr) : 0;
                    if (count > 0)
                    {
                        //Exists
                        return "validation_error";
                    }
                    else
                    {
                        //Unique username....add it to the database
                        string main_query = $"INSERT INTO {placeholder} (Name, Email, Registration_Number, Password, Grade) VALUES (@Name, @Email, @Registration_Number, @Password, @Grade)";
                        //I read somewhere on the internet that using parameters is good to prevent SQL injection attacks n shi -j

                        //making the command and adding in the parameters
                        SqlCommand main_cmd = new SqlCommand(main_query, connection);
                        main_cmd.Parameters.AddWithValue("@Name", Name);
                        main_cmd.Parameters.AddWithValue("@Password", Password);
                        main_cmd.Parameters.AddWithValue("@Registration_Number", RegistrationNumber);
                        main_cmd.Parameters.AddWithValue("@Email", Email);
                        main_cmd.Parameters.AddWithValue("@Grade", Grade);


                        main_cmd.ExecuteNonQuery();
                        return "OK";

                       
                    }
                }
           // SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-3IHB7TU;Initial Catalog=Edu_portal;Integrated Security=True;Encrypt=True");
          
                }

            catch (Exception e)
            {
                return $"Connection_Error_1 {e}";
            }

            //takes the name and the credentials  check
            //makes sure en mafeesh two people with same id [validation] check
            //if yes put it in database and return check
            //return true
            //else return false
            //put the name of the student and registration who signed up in the grade database


          
        }

        public bool log_in()
        {
            string placeholder = null;

            //this should have just the registration number and the password
            if (student(RegistrationNumber))
            {
                placeholder = "Student_Personal_Info";

            }
            else if(!student(RegistrationNumber)) 
            {
                placeholder = "Teacher_Personal_Information";
                
            }


            try { 

            var connectionString = ConfigurationManager.ConnectionStrings["EduPortalDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString)) {

                connection.Open();

                //the SQL query n the SQL command to check if this user already exists or not.
                string query= $"SELECT COUNT(*) FROM {placeholder} WHERE Registration_Number = @RegistrationNumber AND Password = @Password";
                SqlCommand query_cmd = new SqlCommand(query, connection);
                query_cmd.Parameters.AddWithValue("@Password", Password);
                query_cmd.Parameters.AddWithValue("@RegistrationNumber", RegistrationNumber );

                var dr = query_cmd.ExecuteScalar();

        

                //i found this on the internet and added cuz "dr" returns null sometimes and i dont want that -j
                int count = (dr != null) ? Convert.ToInt32(dr) : 0;
                if (count > 0)
                {
                    //Exists
                    return true;
                }
                else
                {
                    return false;
                }

}

            }
            catch(Exception e) {
                MessageBox.Show(e.Message);
            }
            


            return false;
        }

    }

    class School
    {
        class Settings
        {
            public void change_password(string registration_num)
            {
                //to change the password of the user
                //you should change the value in the User_Session
                //and change the value in the database

            }
            public void change_email(string registration_num)
            {
                //same as the change_password
            }

        }

        class Science
        {
            static int total_mark;
            static int final_mark;
            static int midterm_mark;
            static int assignment_mark;


            //make properties to validate this?
            public Science fetch_data()
            {
                //should access the database and put in all the values of the student
                //in the static variables so it is easier to access


                //i put this to just silence the error
                Science sci=new Science();
                return  sci;

            }


        }

        class Math
        {
            //same as Science
        }

        class English
        {
            //same as Science
        }
    }
  
    abstract class User:School
    {
        public abstract void open_dashboard();
        public abstract void results();
    }

    class Student : User
    {
        public override void open_dashboard()
        {
            throw new NotImplementedException();
            //open the dashboard
        }
        public override void results()
        {
            throw new NotImplementedException();
        }
    }

    class Teacher : User
    {
        public override void open_dashboard()
        {
            throw new NotImplementedException();
            //open the dashboard
        }
        public override void results()
        {
            throw new NotImplementedException();
        }
    }

    class User_Session
    {
        public static string name;
        public static string email;
        public static string password;
        public static string registration_number;
        public static string grade;
    }


    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SignUp signup = new SignUp();

            Application.Run(new SignUp());
        }
    }
}
