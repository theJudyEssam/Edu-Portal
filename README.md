# Eduportal: your gateway to knowledge

_The educational portal is created to enhance and facilitate interaction and collaboration between students and teachers. Its purpose is to serve as a gateway for students and teachers to have better access to and utilization of grades and educational materials. Key features include course management, assessment management, and user profile._

# Functional Requirements:

 ## 1. User Authentication and Authorization:

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

## 2. Class Description:

  ## Class Overview

### PROFILE
Defines all the instance variables common to all users and validates them during the signup process in the WinForms page.

### AUTHENTICATION
- Identifies if the registration number belongs to a teacher or student.
- Places user information into static variables through the `USER_SESSION` class.
- Authenticates whether the user already exists in the database during signup.
- Authenticates the correctness of user information during login.

### SETTINGS
Provides methods that allow users to change their email and password through the profile WinForms page.

### USER_SESSION
Stores all attribute values initially created and input in the `PROFILE` class. These values are made static for use throughout all other classes/WinForms pages.

### USER
Contains methods used polymorphically to open the correct dashboard and results page depending on whether the user is a student or teacher.

### TEACHER
- Defines the grade and subject the teacher will teach.
- Inputs student grades, adds study material and sends both to the database.
- Methods `dashboard` and `result` open the teacher version of these pages.

### STUDENT
- Keeps each student's unique grades.
- Retrieves material data from the database.
- Methods `dashboard` and `result` open the student version of these pages.

### SUBJECT
Defines every grade in a student's assessment and sends these grades to the database.

### ADMINISTRATION
- Defines the admin role.
- Allows admins to retrieve data about students and teachers.
- Enables admins to delete any student or teacher from the database.

Final Class Diagram:

![image](https://github.com/theJudyEssam/Edu-Portal/assets/166221535/1a9a9542-e307-4638-9b37-46442784b2e4)


#Some snapshots of the interface

##Sign-up / Log-in

![image](https://github.com/theJudyEssam/Edu-Portal/assets/166221535/53dd9703-0cb2-4f0b-99a2-1899a6ba799a)


##Dashboard

![image](https://github.com/theJudyEssam/Edu-Portal/assets/166221535/629de6ab-b99e-48b1-8ec8-9f17c348a45c)



### README written by Yara Adel Khedr


