using System;
using System.Collections.Generic;

namespace student_exercises
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort CohortName { get; set; }
        public List<Exercise> Exercises { get; set; }
        public Student(string first, string last, string handle, Cohort cohort)
        {
            FirstName = first;
            LastName = last;
            SlackHandle = handle;
            CohortName = cohort;
            Exercises = new List<Exercise>();
        }

        public void ShowExercises()
        {
            foreach (Exercise exercise in Exercises)
            {
                Console.WriteLine($"{exercise.Name}");
            }
        }

    }

}