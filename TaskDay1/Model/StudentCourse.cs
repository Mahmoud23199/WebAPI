﻿using System.ComponentModel.DataAnnotations.Schema;

namespace TaskDay1.Model
{
    public class StudentCourse
    {
        public int Id { get; set; }


        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }


        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
