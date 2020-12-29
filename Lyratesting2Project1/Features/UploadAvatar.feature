Feature: UploadAvatar
After I log in my account, I want to upload my avatar.

@mytag
Scenario: Upload an Avatar
	Given I am in the  home  page
	And I can login  my  account
	| username | password |
    | test001  | Test1234 |
	When I want to change my avatar
	Then I can upload my avatar successfully
