using System.Collections.Generic;
using DataStructures.Enums;

namespace Interfaces.Services
{
    public interface ICalculatorService
    {
        string Calculate(List<string> operands, List<CalculatorOperatorsEnum> operators);
    }
}