using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;



namespace Edu_Portal
{
    public class Profile    //this class is made for basically validation of the variables only :>
    {
        //the private properties AKA the values
        private string name;
        private string password;
        private string registration_number;
        private string email;
        private string grade;
        private string Teaching_Subject;
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
            set { registration_number = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string teaching_subject
        {
            get { return Teaching_Subject; }
            set { Teaching_Subject = value; }
        }

        //three types of constructors
        public Profile(string n, string p, string r, string e, string g, bool student, string t)  //this is the first constructor that takes in the "sign up" information
        {
            grade = g;
            Name = n;
            Password = p;
            RegistrationNumber = r;
            Email = e;
            is_student = student;
            teaching_subject = t;
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
        public static string teaching_subject;
    }
    class Authenticate : Profile  //the class for Authenticating purposes
    {
        public Authenticate(string n, string p, string r, string e, string g, bool student, string teaching_subject) : base(n, p, r, e, g, student, teaching_subject) { }
        public Authenticate(string r, string p) : base(r, p) { } 
        public Authenticate() { } 


        static public bool student(string Reg) //checks if the registration number belongs to the student or the teacher.
        {
            //IF THE REGISTRATION NUMBER STARTS WITH A "2"
            if (Reg[0] == '2')
            {
                return true;
            }
            return false;
        }

        protected void put_in_static(string placeholder, string p, string r)  //puts the credentials in a static variable
        {
           // MessageBox.Show("p is" + p);
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["EduPortalDB"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string get_query = $"SELECT * FROM {placeholder} WHERE Registration_Number = @RegistrationNumber AND Password = @Password";
                    SqlCommand get_cmd = new SqlCommand(get_query, connection);
                    get_cmd.Parameters.AddWithValue("@Password", p);
                    get_cmd.Parameters.AddWithValue("@RegistrationNumber", r);


                    using (SqlDataReader reader = get_cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            string registrationNumber = reader["Registration_Number"].ToString();
                            string password = reader["Password"].ToString();
                            string name = reader["Name"].ToString();
                            string email = reader["Email"].ToString();
                            string grade = reader["Grade"].ToString();


                            User_Session.name = name;
                            User_Session.email = email;
                            User_Session.password = password;
                            User_Session.registration_number = registrationNumber;
                            User_Session.grade = grade;

                            if (!student(r))  //if the user is a teacher, add the subject that they teach too.
                            {
                                string teaching_subject = reader["Teaching_Subject"].ToString();
                                User_Session.teaching_subject = teaching_subject;
                            }


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

           // MessageBox.Show(teaching_subject);
            string placeholder;
            if (is_student)  //so i know where to put the credentials i recieve
            {
                placeholder = "Student_Personal_Info";
            }
            else
            {
                placeholder = "Teacher_Personal_Inform";
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
                    int count = (dr != null) ? Convert.ToInt32(dr) : 0;//i found this on the internet and added cuz "dr" returns null sometimes and i dont want that -j

                    if (count > 0)
                    {
                        //Exists so returns a "validation error"
                        return "validation_error";
                    }
                    else
                    {
                        if (is_student) // add the user's credentials to their Respective Grade Database
                        {
                            string grade = "Grade_" + Grade;
                            string grade_query = $"INSERT INTO {grade} (Student_Name, Registration_Number) VALUES (@Name, @Registration_Number)";
                            SqlCommand query_cmd = new SqlCommand(grade_query, connection);
                            query_cmd.Parameters.AddWithValue("@Name", Name);
                            query_cmd.Parameters.AddWithValue("@Registration_Number", RegistrationNumber);
                            query_cmd.ExecuteNonQuery();
                        }


                        //Unique username....add it to the database
                        string main_query = $"INSERT INTO {placeholder} (Name, Email, Registration_Number, Password, Grade) VALUES (@Name, @Email, @Registration_Number, @Password, @Grade)";


                        SqlCommand main_cmd = new SqlCommand(main_query, connection);
                        main_cmd.Parameters.AddWithValue("@Name", Name);
                        main_cmd.Parameters.AddWithValue("@Password", Password);
                        main_cmd.Parameters.AddWithValue("@Registration_Number", RegistrationNumber);
                        main_cmd.Parameters.AddWithValue("@Email", Email);
                        main_cmd.Parameters.AddWithValue("@Grade", Grade);
                        main_cmd.ExecuteNonQuery();

                        if (!student(RegistrationNumber))
                        {
                            string teacher_query = $"UPDATE Teacher_Personal_Inform SET Teaching_Subject = @Teaching_Subject WHERE Registration_Number = @Registration_Number";
                            SqlCommand teacher_ = new SqlCommand(teacher_query, connection);
                            teacher_.Parameters.AddWithValue("@Teaching_Subject", teaching_subject);
                            teacher_.Parameters.AddWithValue("@Registration_Number", RegistrationNumber);


                            teacher_.ExecuteNonQuery();
                        }
                        put_in_static(placeholder, Password, RegistrationNumber);
                       // MessageBox.Show("your subj is is:" + User_Session.teaching_subject);

                        return "OK";  

                    }
                }
            }
            catch (Exception e)
            {
                return $"Connection_Error_1 {e}";
            }
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
                placeholder = "Teacher_Personal_Inform";
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

                        put_in_static(placeholder, Password, RegistrationNumber); //i just made it in a whole other function
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


        static public void go_back()
        {
            User user;
            //user = Authenticate.student(User_Session.registration_number) ? new Student() : new Teacher();
            if (student(User_Session.registration_number))
            {
                user = new Student();
            }
            else
            {
                user = new Teacher();
            }


            user.open_dashboard();
        }

    }
    class Subject
    {
        public string total_mark = "U";
        public string final_mark = "U";
        public string midterm_mark = "U";
        public string assignment_mark = "U";


        //make properties to validate this?
        public static Subject fetch_data(string Subject)
        {
            // MessageBox.Show("I am in the fetch data");
            Subject sub = new Subject();
            string grade = User_Session.grade;
            string registration_number = User_Session.registration_number;
          
            try
            {


                var connectionString = ConfigurationManager.ConnectionStrings["EduPortalDB"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    //MessageBox.Show(Grade);

                    string get_query = $"SELECT * FROM Grade_{grade} WHERE Registration_Number = @RegistrationNumber";
                    using (SqlCommand get_cmd = new SqlCommand(get_query, connection))
                    {

                        get_cmd.Parameters.AddWithValue("@RegistrationNumber", registration_number);


                        using (SqlDataReader reader = get_cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                if (sub.final_mark != null)
                                    sub.final_mark = reader[$"{Subject}_Final_Mark"].ToString();

                                if (sub.total_mark != null)
                                    sub.total_mark = reader[$"{Subject}_Total_Mark"].ToString();

                                if (sub.assignment_mark != null)
                                    sub.assignment_mark = reader[$"{Subject}_Assignments_Mark"].ToString();

                                if (sub.midterm_mark != null)
                                    sub.midterm_mark = reader[$"{Subject}_Midterm_Mark"].ToString();

                                //MessageBox.Show($"Data fetched for {Subject}: FinalMark={sub.final_mark}, TotalMark={sub.total_mark}, AssignmentMark={sub.assignment_mark}, MidtermMark={sub.midterm_mark}");

                            }

                            else
                            {
                                MessageBox.Show($"No data found for registration number {registration_number}.");
                            }


                        }

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


            return sub;

        }
    }
    abstract class User : Authenticate
    {
        public abstract void open_dashboard();
        public abstract void results();
    }

    class Student : User
    {
        public Subject[] subjects;

        public Student()
        {
            subjects = new Subject[3];
        }
        public override void open_dashboard()
        {
            Student_Dashboard student = new Student_Dashboard();
            student.Show();

            //open the dashboard
        }
        public override void results()
        {

            subjects[0] = Subject.fetch_data("Science");

            if (subjects[0].final_mark == null)
                MessageBox.Show(subjects[0].final_mark);


            subjects[1] = Subject.fetch_data("Math");
            subjects[2] = Subject.fetch_data("English");
        }

        public DataTable materials = new DataTable();
        public void Materials()
        {
          //  MessageBox.Show("Successful");
            try { SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable tables = new DataTable();
            //basically gets the materials of the guy's grade
            var connectionString = ConfigurationManager.ConnectionStrings["EduPortalDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter($@"SELECT Teacher_Name, Grade, Materials_Link, Subject_Name FROM Materials_Table WHERE Grade = {User_Session.grade}", connection);
                adapter.Fill(materials);
            } }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

           // MessageBox.Show("Successful");
            
        }
    }
    class Teacher : User
    {
        //this is the data where we are going to insert the grades in, it reflects the actual database
        public DataTable Student_Grades = new DataTable();
        private SqlDataAdapter adapter;
        //static variables from User_Session Class
        string grade = User_Session.grade;
        string subject = User_Session.teaching_subject;
        public override void open_dashboard()
        {
            Teacher_Dashboard teacher = new Teacher_Dashboard();
            teacher.Show();
        }
        public override void results()
        {

            var connectionString = ConfigurationManager.ConnectionStrings["EduPortalDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter($@"SELECT Student_Name, Registration_Number, {subject}_Total_Mark, {subject}_Final_Mark, {subject}_Midterm_Mark, {subject}_Assignments_Mark FROM Grade_{grade}", connection);
                adapter.Fill(Student_Grades);
            }
        }

        public void Save_Data(string reg, string total_mark, string final_mark, string midterm, string assignments_mark)
        {
            try {

                var connectionString = ConfigurationManager.ConnectionStrings["EduPortalDB"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = $"UPDATE Grade_{User_Session.grade} SET {User_Session.teaching_subject}_Total_Mark = {total_mark}, {User_Session.teaching_subject}_Final_Mark = {final_mark},  {User_Session.teaching_subject}_Midterm_Mark = {midterm}, {User_Session.teaching_subject}_Assignments_Mark = {assignments_mark} WHERE Registration_Number = @Registration_Number";
                    using(SqlCommand get_cmd = new SqlCommand(query, conn))
                    {
                        get_cmd.Parameters.AddWithValue("@Registration_Number", reg);
                        get_cmd.ExecuteNonQuery();
                    }
                }

            } catch(Exception ex) {

                MessageBox.Show(ex.Message);
            }
          
        }


        public void Materials(string material)
        {
            try
            {

                var connectionString = ConfigurationManager.ConnectionStrings["EduPortalDB"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = $"INSERT into Materials_Table (Teacher_Name, Grade, Subject_Name, Materials_Link) VALUES (@T_Name, @G, @S_Name, @M_Link)";
                    using (SqlCommand get_cmd = new SqlCommand(query, conn))
                    {
                        get_cmd.Parameters.AddWithValue("@T_Name", User_Session.name);
                        get_cmd.Parameters.AddWithValue("@G", User_Session.grade);
                        get_cmd.Parameters.AddWithValue("@S_Name", User_Session.teaching_subject);
                        get_cmd.Parameters.AddWithValue("@M_Link", material);
                        get_cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Link has been added!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }


   class Settings:Authenticate
        {
        
        public bool change_password(string new_password, string old_password)
        {
            // we need to check if that user is a student or teacher to search in the right DB
           // MessageBox.Show(User_Session.registration_number);
            string placeholder = student(User_Session.registration_number) ? "Student_Personal_Info" : "Teacher_Personal_Inform";


            //we need to check if the password he typed was legit or not:

            if (User_Session.password != old_password)
            {
                return false;
            }
            string new_query = $"UPDATE {placeholder} SET Password = @password WHERE Registration_Number = @Registration_Number";
            var connectionString = ConfigurationManager.ConnectionStrings["EduPortalDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
               SqlCommand update_cmd = new SqlCommand(new_query, connection );
                update_cmd.Parameters.AddWithValue("@Registration_Number", User_Session.registration_number);
                update_cmd.Parameters.AddWithValue("@Password", new_password);
                update_cmd.ExecuteNonQuery();

            }

            put_in_static(placeholder, new_password, User_Session.registration_number);




            return true;
        }
       public void change_email(string new_email)
            {
            string placeholder = student(User_Session.registration_number) ? "Student_Personal_Info" : "Teacher_Personal_Inform";


            string new_query = $"UPDATE {placeholder} SET Email = @Email WHERE Registration_Number = @Registration_Number";
            var connectionString = ConfigurationManager.ConnectionStrings["EduPortalDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand update_cmd = new SqlCommand(new_query, connection);
                update_cmd.Parameters.AddWithValue("@Registration_Number", User_Session.registration_number);
                update_cmd.Parameters.AddWithValue("@Email", new_email);
                update_cmd.ExecuteNonQuery();

            }

            User_Session.email = new_email;

        }

        }


    class Adminstration
    {
       
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





//Results Page bt3t el teacher wl student