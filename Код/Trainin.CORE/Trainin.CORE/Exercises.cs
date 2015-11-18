using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainin.CORE
{
   abstract public class Exercises
    {
        protected readonly string _name;
        public Exercises(string NAME)
        {
            _name = NAME;
        }

    }
   class WeightExercises : Exercises
   {
       protected int _weight, _go, _repeat;
       public WeightExercises (string Name, int Weight, int Go, int Repeat):base(Name)
       {
           _weight = Weight;
           _go = Go;
           _repeat = Repeat;
       }
   }
   class SimpleExercises : Exercises
   {
       protected int  _go, _repeat;
       public SimpleExercises(string Name, int Go, int Repeat) : base(Name) 
       {
           _go = Go;
           _repeat = Repeat;
       }
   }
   class CardioExercises : Exercises
   {
       protected int _minute;
       public enum ListOfCardioExercises {Цой,Икарус};
       public CardioExercises (string Name, int Minute): base (Name)
       {
           _minute = Minute;
       }
   }
}
