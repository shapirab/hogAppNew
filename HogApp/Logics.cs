using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HogApp
{
    public class Logics
    {
        private int increment = 10;
        public int addPointsToStudent(Student student)
        {
            student.Points += increment;
            StudentsDB.updateStudentPoints(student.Points, student.StudentID);
            int totalStudentPoints = StudentsDB.getStudentPoints(student.StudentID);

            House house = HouseDB.getHouse(student.HouseID);
            house.HousePoints += increment;
            HouseDB.updateHousePoints(house.HousePoints, house.HouseID);
            return totalStudentPoints;
        }
        public int subtractPointsFromStudent(Student student)
        {
            student.Points -= increment;
            StudentsDB.updateStudentPoints(student.Points, student.StudentID);
            int totalStudentPoints = StudentsDB.getStudentPoints(student.StudentID);

            House house = HouseDB.getHouse(student.HouseID);
            house.HousePoints -= increment;
            HouseDB.updateHousePoints(house.HousePoints, house.HouseID);
            return totalStudentPoints;
        }
        public static string getCurrentHouseChampion(int houseID)
        {
            string currentChampionName = null;
            Student currentChampion = new Student();
            List<Student> students = StudentsDB.loadAllStudents();
            List<Student> houseMembers = new List<Student>();
            foreach (Student student in students)
            {
                if(student.HouseID == houseID)
                {
                    houseMembers.Add(student);
                }
            }
            foreach(Student houseMember in houseMembers)
            {
                if(houseMember.Points > currentChampion.Points)
                {
                    currentChampion = houseMember;
                }
            }
            currentChampionName = currentChampion.FullName;
            return currentChampionName;
        }
        public static string getCurrentSchoolChampion()
        {
            string currentChampionName = null;
            Student currentChampion = new Student();
            List<Student> students = StudentsDB.loadAllStudents();

            foreach (Student potentialChamp in students)
            {
                if (potentialChamp.Points > currentChampion.Points)
                {
                    currentChampion = potentialChamp;
                }
            }
            currentChampionName = currentChampion.FullName;
            return currentChampionName;
        }
    }
}