Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Multiply two numbers
	Given the first number is 2
	And the second number is 5
	When the two numbers are multiplied
	Then the result should be 10

Scenario: Divide two numbers
	Given the first number is 8
	And the second number is 4
	When the two numbers are divided
	Then the result should be 2

Scenario: Divide by zero
	Given the first number is 8
	And the second number is 0
	When the two numbers are divided
	Then the result should be You cannot divide by zero.

Scenario: Add n numbers
	Given the numbers are 1,2,3,4
	When the numbers are added
	Then the result should be 10

Scenario: Multiply n numbers
	Given the numbers are 3,4,10
	When the numbers are multiplied
	Then the result should be 120

Scenario: Divide n numbers
	Given the numbers are 100,10,2
	When the numbers are divided
	Then the result should be 5

Scenario: Divide n numbers by zero
	Given the numbers are 100,0,4
	When the numbers are divided
	Then the result should be You cannot divide by zero.

Scenario: Calculate n numbers with any operations
	Given the operation is 10,*,2,+,5,-,4
	When the operation is calculated
	Then the result should be 21

Scenario: Calculate n numbers with any operations and divide by zero
	Given the operation is 10,*,2,/,0,-,4
	When the operation is calculated
	Then the result should be You cannot divide by zero.

	
