Feature: Degience LogIn

Logging into the Degience Application

Scenario: John Logs into the Degience Application
	Given John is on the login page
	When John fills in the required details
	And John clicks on the login button
	Then John should be logged in to the application
