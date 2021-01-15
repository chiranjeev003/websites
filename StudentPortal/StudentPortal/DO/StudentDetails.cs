using StudentPortal.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StudentPortal.DO
{
    public class StudentDetails
    {
        public List<Student> studentResult()
        {
            List<Student> studentList = new List<Student>();

            studentList = studentDetails();

            foreach (var student in studentList)
            {

                var count = 0;
                string[] subject = new string[5];
                if (student.EC1 < 30)
                {
                    subject[count] = "EC1";
                    count++;
                }
                if (student.EC2 < 30)
                {
                    subject[count] = "EC2";
                    count++;
                }
                if (student.EC3 < 30)
                {
                    subject[count] = "EC3";
                    count++;
                }
                if (student.EC4 < 30)
                {
                    subject[count] = "EC4";
                    count++;
                }
                if (student.EC5 < 30)
                {
                    subject[count] = "EC5";
                    count++;
                }

                if (count > 2)
                    student.Result = "Fail";
                else if (count == 2)
                {
                    var firstSubject = subject[0];
                    var secondSubject = subject[1];

                    var marksOfFirstSubject = Convert.ToInt32(typeof(Student).GetProperty(firstSubject).GetValue(student));
                    var marksOfSecondSubject = Convert.ToInt32(typeof(Student).GetProperty(secondSubject).GetValue(student));

                    var total = marksOfFirstSubject + marksOfSecondSubject;
                    if (total < 54)
                        student.Result = "Fail";
                    else
                    {
                        typeof(Student).GetProperty(firstSubject).SetValue(student, 30);
                        typeof(Student).GetProperty(secondSubject).SetValue(student, 30);
                        student.Result = "Pass";
                    }
                }
                else if (count == 1)
                {
                    var firstSubject = subject[0];

                    var marksOfFirstSubject = Convert.ToInt32(typeof(Student).GetProperty(firstSubject).GetValue(student));

                    if (marksOfFirstSubject < 24)
                        student.Result = "Fail";
                    else
                    {
                        typeof(Student).GetProperty(firstSubject).SetValue(student, 30);
                        student.Result = "Pass";
                    }
                }
                else
                    student.Result = "Pass";

            student.TotalMarks = student.EC1 + student.EC2 + student.EC3 + student.EC4 + student.EC5;
            }

            return studentList;
        }

        public List<Student> studentDetails()
        {
            List<Student> studentList = new List<Student>();
            string connectionString = ConfigurationManager.ConnectionStrings["connectionToDatabase"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(@"SELECT FStudentId, FstudentName, EC1, EC2, EC3, EC4, EC5
                                                  FROM(SELECT FStudentID, FStudentName,
                                                     Max(CASE WHEN FSubject = 'EC1' THEN FMarks END) AS 'EC1',
                                                     Max(CASE WHEN FSubject = 'EC2' THEN FMarks END) AS 'EC2',
                                                     Max(CASE WHEN FSubject = 'EC3' THEN FMarks END) AS 'EC3',
                                                     Max(CASE WHEN FSubject = 'EC4' THEN FMarks END) AS 'EC4',
                                                     Max(CASE WHEN FSubject = 'EC5' THEN FMarks END) AS 'EC5'
                                                  FROM student GROUP BY FStudentID, FStudentName) a
                                                  ", con);
                cmd.CommandType = CommandType.Text;
                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var students = new Student();

                    students.FStudentID = Convert.ToInt32(rdr["FStudentID"]);
                    students.FStudentName = rdr["FStudentName"].ToString();
                    students.EC1 = Convert.ToInt32(rdr["EC1"]);
                    students.EC2 = Convert.ToInt32(rdr["EC2"]);
                    students.EC3 = Convert.ToInt32(rdr["EC3"]);
                    students.EC4 = Convert.ToInt32(rdr["EC4"]);
                    students.EC5 = Convert.ToInt32(rdr["EC5"]);
                    students.Result = null;
                    students.TotalMarks = students.EC1 + students.EC2 + students.EC3 + students.EC4 + students.EC5;

                    studentList.Add(students);
                }
            }

            return studentList;
        }
    }
}