Feature: UsingCalculatorBasicReliability
	In order to calculate the Basic Musa model's failures/intensities
	As a Software Quality Metric enthusiast
	I want to use my calculator to do this

@BasicReliability
Scenario: CalculatingCurrentFailureIntensity
	Given I have a calculator
	When I have entered "10" and "50" and "100" into the calculator and press CFI
	Then the CFI result should be "5"

@BasicReliabilityAF
Scenario: CalculatingAverageFailures
	Given I have a calculator
	When I have entered "100" and "10" and "100" into the calculator and press AF
	Then the AF result should be "100"