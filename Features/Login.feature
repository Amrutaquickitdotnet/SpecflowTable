Feature: Login functionality.

@tag1
Scenario: successful login with valid credentials
	Given OrangeHrm Home Page
	When User enter Credentials
	| Field    | Value    |
	| Username | Admin    |
	| password | admin123 |
	And Click on Login Button
	Then Successful login message should displayed.
