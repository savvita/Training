using System;
using System.Text;

namespace Training
{
    internal abstract class Exercise
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }

        public int Sets { get; protected set; }
        public int Repetitions { get; protected set; }

        public Exercise(string name, int sets, int repetitions, string description = "")
        {
            Name = name;
            Sets = sets;
            Repetitions = repetitions;
            Description = description;
        }

        public override string ToString() => String.Format("{0}. Sets: {1} of {2} repetitions\nDescription: {3}\n", Name, Sets, Repetitions, Description);

        public static Exercise GetExercise(string str)
        {
            string name = str.Substring(0, str.IndexOf('.'));
            name = Trim(name);

            int idx = str.IndexOf(':') + 1;
            int sets = Convert.ToInt32(str.Substring(idx, str.IndexOf("of") - idx));

            idx = str.IndexOf("of") + "of".Length + 1;
            int rep = Convert.ToInt32(str.Substring(idx, str.Substring(idx).IndexOf(' ')));

            return ExerciseCreator.Create(name, sets, rep);
        }

        private static string Trim(string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                    sb.Append(str[i]);
            }

            return sb.ToString();
        }
    }
}
