using System.Collections.Generic;
using System.Linq;
using DataStructures.Enums;
using Interfaces.PlatformServices;
using Interfaces.Services;
using Prism.Navigation;
using Prism.Services;
using ViewModels.ViewModels.Base;

namespace ViewModels.ViewModels
{
    public class StartHerePageViewModel : NavigationBaseViewModel
    {
        public StartHerePageViewModel(INavigationService navigationService, 
            IDeviceService deviceService,
            IUserDialogService userDialogService,
            IPlaySoundService playSoundService,
            ICalculatorService calculatorService)
            : base(navigationService, deviceService, userDialogService, playSoundService)
        {
            CalculatorService = calculatorService;
        }

        private Stack<CalculatorOperatorsEnum> _operators = new Stack<CalculatorOperatorsEnum>();
        private Stack<string> _operands = new Stack<string>();

        public void Calculate(string operation)
        {
            PlaySoundService.PlaySound(AppSoundsEnum.DigitalButton);
            var addNew = !_operands.Any() || (_operands.Count - _operators.Count) == 0;
            switch (operation)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    if (addNew)
                    {
                        _operands.Push(operation);
                    }
                    else
                    {
                        var lastOperand = _operands.Pop();
                        _operands.Push(lastOperand + operation);
                    }
                    break;
                case "-":
                    _operators.Push(CalculatorOperatorsEnum.Minus);
                    break;
                case "+":
                    _operators.Push(CalculatorOperatorsEnum.Plus);
                    break;
                case "=":
                    _operators.Push(CalculatorOperatorsEnum.Equal);
                    break;
                case "C":
                    _operators.Clear();
                    _operands.Clear();
                    break;
            }

            OutputResult = CalculatorService.Calculate(_operands.ToList(), _operators.ToList());
        }

        public string OutputResult { get; set; }

        public async void NavigateToManualPage()
        {
            await NavigateToUri(nameof(AppPagesEnum.ManualPage));
        }

        private ICalculatorService CalculatorService { get; }
    }
}