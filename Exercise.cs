using System;

namespace student_exercises
{
    class Exercise
    {
        public string Name { get; set; }
        public string Language { get; set; }

        public Exercise(string name, string lang)
        {
            Name = name;
            Language = lang;
        }
    }
}