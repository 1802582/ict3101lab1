Feature: Factorial
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Factorial
Scenario: Factorial one number
	Given I have a calculator
	When I have entered "6" into the calculator and press factorial
	Then the Factorial result should be "720"

@Factorial
Scenario: Factorial zero
	Given I have a calculator
	When I have entered "0" into the calculator and press factorial
	Then the Factorial result should be "1"