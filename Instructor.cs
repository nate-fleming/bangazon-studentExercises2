using System;

namespace student_exercises
{
    class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort CohortName { get; set; }

        public string Specialty { get; set; }

        public void AddExercise(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
        }
    }
}