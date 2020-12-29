Feature: Logout
After I finish my study, I want to log out my account

@mytag
Scenario: Log out account
	Given I am in the home page
	And  I can login my account
	| username | password |
    | test001  | Test1234 |
	When I finish study and log out my account
	Then I log out success
