# Calculator
This app was written by student. He didn't have time to add "/" and "*" operations to the app.

You need to finish it up. Implement US below, fix the bug and implement additional tasks in "Developer notes".


# User story
As a user I want to have a calculator:
- Supports "add", "substract", "divide", "multiple" operations.
- "C" button should clear all previous calculations.
- "=" button should display the result in ResultEntry.
- Should be able to work (recieve and output) with 10 digit numbers. If a user enters/gets more than 10 digits - output "Error" in ResultEntry.
- If user got "Error" message - further calculations are only possible after "C" button pressed.
- User presses "+" ("-" or "*" or "/" or "=") twice or more - ignore it. App should ignore all unexpected actions and receive only valid input.


# Additional bug
Steps to reproduce:
1. Tap "i" icon in the top right corner to navigate Manual page
2. Tap "i" icon in the top right corner again to navigate Wiki page
3. Tap back

ERROR: Manual page is opened

EXPECTED: Main page is opened (no matter how much time user tapped "i")


# Developer notes
You should use ICalculatorService.Calculate and you can't change ICalculatorService (let's imagine you can't).

You can change/refactor ICalculatorService.Calculate implementation but don't change the interface. And you should use the interface to do calculations.

You also can change/refactor other parts of the app. You can use additional nuget packages if needed.

"/" and "*" are not implemented. Please add two buttons to the layout and implement them as well.

Additional tasks:
1. Cover business logic in ICalculatorService.Calculate by Unit tests.
2. Refactor app using recommendations for MVVM pattern
3. Make any other improvements/refactors and describe them in README.md
4. Customize buttons on the keyboard in iOS to make them looking as in Android. But you should still use Xamarin.Forms.Button control as a base.

