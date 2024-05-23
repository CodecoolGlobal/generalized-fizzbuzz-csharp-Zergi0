using CodeCool.FizzBuzzCooperation.Model;

namespace CodeCool.FizzBuzzCooperation.Service.Division;

public interface IDivisionService
{
    public bool CanDivide(int number, Operator? op, params int[] divisors);
    public bool CanDivide(int number, int divisor);
}
