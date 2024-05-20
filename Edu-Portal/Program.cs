﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace Edu_Portal
{
    public class Profile
    {
        //this class is made for basically validation of the variables only :>
        //THE VALIDATION FOR THE VALUES IS IN THE SIGN_UP PAGE CODE ITSELF

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
            set
            {
                registration_number = value;



            }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public Profile(string n, string p, string r, string e, string g, bool student)  //this is the first constructor that takes in the "sign up" information
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
        public Profile() { } //default constructorr

    }
    class User_Session  // a class of static variables
    {

        public static string name;
        public static string email;
        public static string password;
        public static string registration_number;
        public static string grade;
    }


    class Authenticate : Profile
    {
        public Authenticate(string n, string p, string r, string e, string g, bool student) : base(n, p, r, e, g, student) { } //this is the first constructor that we are going to call in the sign up part
        public Authenticate(string r, string p) : base(r, p) { } //this will be the constructor for the login page
        public Authenticate() { } // a default constructor that i am still not sure why i put , but its for inheritance purposes


        public bool student(string Reg) //checks if the registration number belongs to the student or the teacher.
        {
            //IF THE REGISTRATION NUMBER STARTS WITH A "2"
            if (Reg[0] == '2')
            {
                return true;
            }
            return false;
        }

        public void put_in_static( string placeholder)
        {
            try
            {

                var connectionString = ConfigurationManager.ConnectionStrings["EduPortalDB"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string get_query = $"SELECT * FROM {placeholder} WHERE Registration_Number = @RegistrationNumber AND Password = @Password";
                    SqlCommand get_cmd = new SqlCommand(get_query, connection);
                    get_cmd.Parameters.AddWithValue("@Password", Password);
                    get_cmd.Parameters.AddWithValue("@RegistrationNumber", RegistrationNumber);


                    using (SqlDataReader reader = get_cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {


                            string registrationNumber = reader["Registration_Number"].ToString();
                            string password = reader["Password"].ToString();
                            string name = reader["Name"].ToString();
                            string email = reader["Email"].ToString();


                            User_Session.name = name;
                            User_Session.email = email;
                            User_Session.password = password;
                            User_Session.registration_number = registrationNumber;

                        }
                    }


                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public string sign_up()
        {

            string placeholder;

            if (is_student)  //so i know where to put the credentials i recieve
            {
                placeholder = "Student_Personal_Info";
            }
            else
            {
                placeholder = "Teacher_Personal_Information";
            }


            try
            {

                var connectionString = ConfigurationManager.ConnectionStrings["EduPortalDB"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString)) //basically use this object within this scope
                {

                    connection.Open();



                    //the SQL query n the SQL command to check if this user already exists or not.
                    string validation_query = $"SELECT COUNT(*) FROM {placeholder} WHERE Registration_Number = @RegistrationNumber";//CHECK IF EMAIL IS SAME OR NOT
                    SqlCommand validation = new SqlCommand(validation_query, connection);
                    validation.Parameters.AddWithValue("@RegistrationNumber", RegistrationNumber);


                    var dr = validation.ExecuteScalar();

                    //i found this on the internet and added cuz "dr" returns null sometimes and i dont want that -j
                    int count = (dr != null) ? Convert.ToInt32(dr) : 0;

                    if (count > 0)
                    {
                        //Exists so return a "validation error"
                        return "validation_error";
                    }
                    else
                    {
                        //MEANS THAT THE USER IS UNIQUE

                        if (is_student)
                        {
                            //string grade = "Grade_" + Grade + "_Table";  fix this later
                            string grade_query = $"INSERT INTO Grade_12_Table (Student_Name, Registration_Number) VALUES (@Name, @Registration_Number)";
                            SqlCommand query_cmd = new SqlCommand(grade_query, connection);
                            query_cmd.Parameters.AddWithValue("@Name", Name);
                            query_cmd.Parameters.AddWithValue("@Registration_Number", RegistrationNumber);
                            query_cmd.ExecuteNonQuery();
                        }


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
                        put_in_static(placeholder);




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
            //this should have just the registration number and the password




            string placeholder = null;
            if (student(RegistrationNumber))
            {
                placeholder = "Student_Personal_Info";
            }
            else if (!student(RegistrationNumber))
            {
                placeholder = "Teacher_Personal_Information";
            }



            try
            {

                var connectionString = ConfigurationManager.ConnectionStrings["EduPortalDB"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();


                    //the SQL query n the SQL command to check if this user exists or not.
                    string query = $"SELECT COUNT(*) FROM {placeholder} WHERE Registration_Number = @RegistrationNumber AND Password = @Password";
                    SqlCommand query_cmd = new SqlCommand(query, connection);
                    query_cmd.Parameters.AddWithValue("@Password", Password);
                    query_cmd.Parameters.AddWithValue("@RegistrationNumber", RegistrationNumber);

                    var dr = query_cmd.ExecuteScalar();



                    //i found this on the internet and added cuz "dr" returns null sometimes and i dont want that -j
                    int count = (dr != null) ? Convert.ToInt32(dr) : 0;
                    if (count > 0)
                    {
                        //Exists n shi
                        //now u need to make a User_Session thing and make it accessbile throughout the whole thing.
                        //store the variables in the static class 

                        put_in_static(placeholder); //i just made it in a whole other function
                        return true;



                    }




                    else { return false; }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }

    }



    class Subject
    {
        public int total_mark;
        public int final_mark;
        public int midterm_mark;
        public int assignment_mark;


        //make properties to validate this?
        public void fetch_data(string Subject)
        {
            Subject subject = new Subject();
            string grade = User_Session.grade;
            string registration_number = User_Session.registration_number;
            string table = "Grade_" + grade + "_Table";


            try {  var connectionString = ConfigurationManager.ConnectionStrings["EduPortalDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string get_query = $"SELECT * FROM {grade} WHERE Registration_Number = @RegistrationNumber";
                SqlCommand get_cmd = new SqlCommand(get_query, connection);

                get_cmd.Parameters.AddWithValue("@RegistrationNumber", registration_number);


                using (SqlDataReader reader = get_cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {


                        final_mark = (int)reader[Subject + "_Final_Mark"];
                        total_mark = (int)reader[Subject + "_Total_Mark"];
                        assignment_mark = (int)reader[Subject + "_Assignment_Mark"];
                        midterm_mark = (int)reader[Subject + "_Midterm_Mark"];



                    }


                }}
           

                //ignore all this
                //should access the database and put in all the values of the student
                //in the static variables so it is easier to access
                //i put this to just silence the error

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        } }



abstract class User
{
    public abstract void open_dashboard();
    public abstract void results();
}

class Student : User
{
    Subject[] subjects;
    public override void open_dashboard()
    {
        Student_Dashboard student = new Student_Dashboard();
        student.Show();

        //open the dashboard
    }
    public override void results()
    {
        Subject science = new Subject();
        science.fetch_data("Science");
        Subject math = new Subject();
        math.fetch_data("Math");
        Subject english = new Subject();
        english.fetch_data("English");
        subjects[0] = science;
        subjects[1] = math;
        subjects[2] = english;
        //Makes three objects for each subject
        //calls fetch data on each subject
        //retrieves the row that has the same data as the registration number
        //puts everything in its respective object
        //adds the object to the array
    }
}

class Teacher : User
{
    DataSet Student_Grades;
    public override void open_dashboard()
    {
        Teacher_Dashboard teacher = new Teacher_Dashboard();
        teacher.Show();
    }
    public override void results()
    { 

            var connectionString = ConfigurationManager.ConnectionStrings["EduPortalDB"].ConnectionString;
            string grade = User_Session.grade;

            using (SqlConnection connection = new SqlConnection(connectionString)) //basically use this object within this scope
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Grade_{grade}_Table", connection);
                adapter.Fill(Student_Grades);


            }
                //DONE
                //Takes the grade that the teacher teaches
                //Puts the Entire Database in the dataset
                //so it can be displayed in a datagrid
            }

            public void Materials()
    {
        //The teacher should be able to add a Google drive link with all the materials
        //no need to implement a database for it or anything
        //still not sure if i do need to even implement this or not
    }
}


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

