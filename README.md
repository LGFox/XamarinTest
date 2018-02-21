# Calculator
This app was written by student. He didn't have time to add "/" and "*" operations to the app.

# User story
As a user I want to have a calculator:
- Supports "add", "substract", "divide", "multiple" operations.
- "C" button should clear all previous calculations.
- "=" button should display the result in ResultEntry.
- Should be able to work (recieve and output) with 10 digit numbers. If a user enters/gets more than 10 digits - output "Error" in ResultEntry.
- If user got "Error" message - further calculations are only possible after "C" button pressed.
- User presses "+" ("-" or "*" or "/" or "=") twice or more - ignore it. App should ignore all unexpected actions and receive only valid input.

# Developer notes
We should use ICalculatorService.Calculate and we can't change ICalculatorService (let's imagine we can't).
You can change/refactor ICalculatorService.Calculate implementation but don't change the interface. And we should use the interface to do calculations.
We also can change/refactor other parts of the app. We can use additional nuget packages if needed.
"/" and "*" are not implemented. Please add two buttons to the layout and implement them as well.

Additional task:
- Cover business logic in ICalculatorService.Calculate by Unit tests.
- Refactor app using recommendations for MVVM pattern
- Make any other improvements/refactors and describe them in README.md
- Customize buttons on the keyboard in iOS to make them looking as in Android. But you should still use Xamarin.Forms.Button control as base.
    

