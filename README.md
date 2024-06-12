### Eduportal: your gateway to knowledge.

_The educational portal is created to enhance and facilitate interaction and collaboration between students and teachers. Its purpose is to serve as a gateway for students and teachers to have better access to and utilization of grades and educational materials. Key features include course management, assessment management, and user profile._

## Functional Requirements:

 # 1. User Authentication and Authorization:

   - Sign up: Students and teachers create accounts with the necessary information required, and then data validation occurs to ensure the data isn’t similar to a previously registered user.

{ 
        ◦ Name 
        ◦ Email
        ◦ Registration Number (starts with a 1 if it’s a teacher, and 2 if it’s a student)
        ◦ Password
        ◦ User Role (student or teacher, as each has different functionalities that they are able to access)
}

  - Login/Logout: Students and teachers log in using unique credentials as well as logout from their accounts.

{
        ◦ Registration Number
        ◦ Password 
} 

-  Course Management:

      ◦ Course Dashboard: Teachers access a dashboard that displays all enrolled students in their course as well as their final grade.

      ◦ Material Upload: Teachers upload their course materials for student use through a Google Documents link.

      ◦ Material Dashboard: Students access a dashboard that displays the materials for all the courses they are enrolled in.

    • Assessment and Progress Tracking:

      ◦ Student Grading: Teachers grade each student enrolled in their course for each quarter of the school year.

      ◦ Student Results: Students view their grades in all courses they are enrolled in for all quarters of the school year.

      ◦ GPA Calculator: Students can calculate their possible GPA based on their grades across different courses.

    • User Profile:

      ◦ User Information: Students and teachers can edit specific profile information.
                
              {
                          ▪ Email
                          ▪ Password
              }

    • Data Handling:

    • User Viewing: Admin can view all students and teachers that are registered within the school.

    • User Deletion: Admin can delete any student and teacher from the school’s database.

# 2. Class Description:

  PROFILE:
      Made for defining all the instance variables that are common between all users, as well as for their validation through their use in the signup WinForms page.
  
  AUTHENTICATION:
      Used to identify if the registration number is that of a teacher or student, place the user information in static variables through the user_session class,   authenticate whether or not the user already exists in the database during signup, as well as authenticate if the information is correct during login. 
  
  SETTINGS:
      Has methods that allow the user to change their email and password through the profile WinForms page.
  
  USER_SESSION:
      Used to store all attribute values that were initially created and input in the profile class, however it makes them static in order for them to be used freely and         repetitively within all the other classes/WinForms pages.

   USER:
      Has methods that will then be used polymorphically in order to open the correct dashboard and results page depending on whether the user is a student or teacher.

  TEACHER:
      Made for defining which grade and subject the teacher is going to teach, as well as for inputting all student grades and adding study material and sending both to the database. In addition, methods dashboard and result open teacher version of these pages.

  STUDENT:
      Made for keeping each student’s unique grades, as well as retrieving the material data from the database. In addition, methods dashboard and result open the student version of these pages.

  SUBJECT:
      Made for defining every single grade in a student’s assessment as well as sending these grades to the database.

  ADMINSTRATION:
      Made for defining the admin, and allows them to retrieve data about students and teachers, as well as delete any student/teacher from the database.



Final Class Diagram:

![image](https://github.com/theJudyEssam/Edu-Portal/assets/166221535/1a9a9542-e307-4638-9b37-46442784b2e4)


