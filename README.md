# MIS 3033 – Midterm Project

This project is meant to be individual.  Feel free to discuss with your colleagues, but I should not academic integrity issues (e.g. Don't get together and do it and then copy paste and add collaborated with at the top).

# Grade Calculator

## Description

The Grade Calculator application will be used to calculate student's grades for a single course.  A course will be comprised of the same 5 areas for grades:

1. Homework
2. Quiz
3. Participation
4. Exams
5. Final Exam

## Requirements

The business partners who have hired you to create the application have required it to be able to do the following:

- Provide a course number and get the following averages:
  - Homework grades
  - Quiz grades
  - Participation grades
  - Exam grades
  - Final Exam grades
  - Final grades
- Provide a student id and get that students averages for each area back and their final grade
- Provide a course number and get back a list of all the students in the course in descending order of their student id with their final grade as a percent and as a letter grade
  - A – >= 90%
  - B – < 90 AND >= 80%
  - C – < 80% AND >= 70%
  - D – < 70% AND >= 60%
  - F – < 59%

The application will be getting all of the data needed for the application through what is commonly coined &quot;Flat Files&quot; in the industry (files that live on your computer and not through a database, in our case we will have them be text files (\*.txt)). The client has requested that the path to the files be placed in a constant in the class that has your main method so that if they need to, they can change it easily in the future.

### File format requirements

- course.txt
  - The course file will have the course number and the instructor's name separated by a comma ","
  - The course file will have the percent for each part of the grade.
    - Homework: 20%
    - Quiz: 25%
    - Etc…
- students.txt
  - Each student will have at least 2 properties about them: last name and student id.  Their first name is optional.  There will always be a student id (you will be able to tell it is the student id since it will be all numbers!) and a last name (so if there is 1 String and 1 Number you know that is the last name (String) and student id (the number))
  - It is a known fact that the temp workers who create this file are clumsy and sometimes do not provide all the information. If the last name or the student id is missing, disregard the line and finishing processing the file.
- homeworks.txt / quizzes.txt / participations.txt / exams.txt / finalexam.txt
  - Each line will be comprised of the student&#39;s id and followed by all of their grades, as a percent, for the particular area.
- **Gotcha&#39;s to look out for**
  - Some of the entry clerks are not consistent with :
    - Whether they put a space after a comma or after the colon&#39;s etc… so make sure you take into account the possibility of a space somewhere you may not expect it (Maybe look at some kind of Trim() method that the String class might have?)
    - The capitalization of things like Homework/homework Quiz/QuIz, etc…

## Deliverables
- classes:
    1. Main.cs
    2. Homework
    3. Quiz
    4. Exam
    5. Course
    6. Student
