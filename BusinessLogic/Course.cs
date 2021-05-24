using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private string courseName;
        private byte numCredits;


        public Course(string courseName)
        {
            CourseName = courseName;
            InstructorName = "STAFF";
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName 
        {
            get => courseName;
            set => courseName = value ?? throw new ArgumentNullException($"{nameof(CourseName)} should not be null");
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits 
        {
            get => numCredits;
            set
            {
                if (value > 29 || value < 1)
                    throw new ArgumentException("Credits should not be over 30 or under 0");
                else
                    numCredits = value;
            }
        }

    }
}
