Feature: Login
	In order to study online courses
	As a student
	I want to login my account

@LoginSuccess
Scenario: Login with vaild username and password
	Given I am on the homepage
	And I can login account
	When I can input valid username and password
	| username | password |
    | test001  | Test1234 |
	Then I can login success


@LoginSuccess
Scenario: Login with valid user name and password, Remember me is selected
	Given I am on the homepage
	And I can login account
	When I can input valid username and password with clicking remember-me
	| username | password |
    | test001  | Test1234 |
	Then I can login success


@LoginFailure
Scenario: Login with invalid user name and password
	Given I am on the homepage
	And I can login account
	When I can input invalid username and password 
	| username | password |
    | test123  | Test5678 |
	Then I login failure

@ResetPassword
Scenario Outline: Reset Password with Errors
	Given I am on the login page but forget password
	And I click reset-password link
	When I input "<email>" email to reset password
	Then I get some "<error>" errors  
	Examples:
	| email      |  error        |
	| 1234@12345 | 该邮箱地址没有注册过帐号 |
	| 1234       | 请输入有效的电子邮件地址 |

