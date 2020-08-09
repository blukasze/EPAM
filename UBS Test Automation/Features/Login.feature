Feature: Login
	In order to fully use the website
	As a UBS customer
	I need to be able to login

Scenario: Failed login
	Given I am on the main page
	And I click on the login button
	When I type in incorrect credentials
	And I click on the submit button
	Then I see the incorrect login or password message