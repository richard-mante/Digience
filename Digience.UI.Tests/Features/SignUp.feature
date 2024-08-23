Feature: Degience SignUp

Signing Up for the Degience Application

Scenario: John signs up for the Degience Application
	Given John is on the sign up page
	When John fills the required information
	And clicks the sign up button
	Then John returns to the log in page to Log in
