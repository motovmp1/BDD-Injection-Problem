Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Create a new employee with a mandatory details
	#Given I opened my application
	#Then I should see employee datails page
	When I fill all the mandatory details 01
	| Name     | Age | Phone      | Email                 |
	| Vinicius | 28  | 9126720999 | vinicius@vinicius.com |
	| Pinho | 26  | 652356566 | pedro@vinicius.com |
	| Rosana | 45  | 4558555 | rosana@vinicius.com |
	| Pedro | 55  | 465565454 | driano@vinicius.com |
	#And I clikc the save button
	#Then I should see all details saved in my application and DB



Scenario Outline:  Create a new employee with second detail
	When I fiil all the mandatory details <Name>, <Age> and <Phone>

Examples: 
	| Name     | Age | Phone      |
	| sandro | 12  | 5656568989 | 
	| rosa | 18  | 5456454544 | 
	| rita | 11  | 4564654654 | 




