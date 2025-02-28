namespace FizzBuzzApi
{
    public class FizzBuzzService
    {
        private DivisionCounter _divisionCounter;

        public FizzBuzzService(DivisionCounter divisionCounter)
        {
            _divisionCounter = divisionCounter;
        }

        public string GetFizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                _divisionCounter.Increment3();
                _divisionCounter.Increment5();
                return "FizzBuzz";
            }
            if (number % 3 == 0)
            {
                _divisionCounter.Increment3();
                return "Fizz";
            }
            if (number % 5 == 0)
            {
                _divisionCounter.Increment5();
                return "Buzz";
            }
            return number.ToString();
        }

        public DivisionCounter GetDivisionCounter()
        {
            return _divisionCounter;
        }
    }

    public class DivisionCounter
    {
        public int DividedBy3 { get; set; } = 0;
        public int DividedBy5 { get; set; } = 0;

        public void Increment3()
        {
            DividedBy3++;
        }

        public void Increment5()
        {
            DividedBy5++;
        }
    }
}
