using Amazon.Lambda.Core;

namespace LambdaUnitTestExample.Tests
{
    public enum Condition {EXCELLENT, GOOD, FAIR, BAD};

    public class Car
    {
        public Condition carCondition;
        public string Make;
        public int speed;

        public Car(string carMake, Condition condition)
        {
            this.Make = carMake;
            this.carCondition = condition;
        }

        public string make(string Make)
        {
            return Make;
        }

        public static string FunctionHandler(string input, ILambdaContext context)
        {
            return input?.ToUpper();
        }

        public int Speed
        {
            get { return speed; }
            set
            {
                if (-50 <= value && value <= 200)
                {
                    speed = value;
                }
            }
        }
    }
}