using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainin.CORE
{
    public abstract class ExercisesCreator
    {
        public Exercises GetExercise();

    }

    public class SimpleExercisesCreator : ExercisesCreator
    {
        public override Exercises GetExercise(string a, int b, int c)
        {
            return new SimpleExercises(a, b, c);
        }
    }
    public class WeightExercisesCreator : ExercisesCreator
    {
        public new Exercises GetExercise(string a, int b, int c, int d)
        {
            return new WeightExercises(a, b, c, d);
        }
    }
    public class CardioExercisesCreator : ExercisesCreator
    {
        public Exercises GetExercise(string a, int b)
        {
            return new CardioExercises(a, b);
        }
    }

}
