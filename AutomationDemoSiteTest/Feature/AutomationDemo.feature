Feature: AutomationDemo
	In order to use the benefit of the website
	I will need to create an account 

@mytag
Scenario: Valid Automation Demo Site
	Given I navigate to website
	#And I click on Register
	And I enter my first name 
	And I enter my last name
	And I enter my Address
	And I enter my Email address
	And I enter phone number
	And I enter my gender
	And I enter my hobbies 
	And I enter my password
	And I confirmed my Password
	When I click on submit button
	#Then I should be able to register an account 