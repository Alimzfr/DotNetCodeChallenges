namespace DotNetCodeChallenges.Services;

public class FizzBuzz
{
    public string[] DoFizzBuzz(int n)
    {
        var result = new string[n];

        var index = 0;
        var number = 1;
        for (; index < n; index++, number++)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                result[index] = "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                result[index] = "Fizz";
            }
            else if (number % 5 == 0)
            {
                result[index] = "Buzz";
            }
            else
            {
                result[index] = number.ToString();
            }
        }

        return result;
    }
}