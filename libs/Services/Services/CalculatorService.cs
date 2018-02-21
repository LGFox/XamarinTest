using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures.Enums;
using Interfaces.Services;

namespace Services.Services
{
    public class CalculatorService : ICalculatorService
    {
        public string Calculate(List<string> operands, List<CalculatorOperatorsEnum> operators)
        {
            var result = string.Empty;
            var operations = new Stack<CalculatorOperatorsEnum>(operators);
            CalculatorOperatorsEnum? op = null;
            var calculatedResult = 0;
            for (int i = operands.Count - 1; i >= 0 ; i--)
            {
                result += operands[i];
                if (operations.Any())
                {
                    switch (op)
                    {
                        case CalculatorOperatorsEnum.Plus:
                            calculatedResult += Convert.ToInt32(operands[i]);
                            break;
                        case CalculatorOperatorsEnum.Minus:
                            calculatedResult -= Convert.ToInt32(operands[i]);
                            break;
                        case null:
                            calculatedResult = Convert.ToInt32(operands[i]);
                            break;
                        case CalculatorOperatorsEnum.Equal:
                            break;
                    }

                    op = operations.Pop();

                    switch (op)
                    {
                        case CalculatorOperatorsEnum.Plus:
                            result += "+";
                            break;
                        case CalculatorOperatorsEnum.Minus:
                            result += "-";
                            break;
                        case CalculatorOperatorsEnum.Equal:
                            result = calculatedResult.ToString();
                            break;
                    }
                }
            }
            return result;
        }
    }
}