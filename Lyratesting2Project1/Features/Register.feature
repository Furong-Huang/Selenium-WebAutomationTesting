Feature: Register
	In order to study online courses
	As a student
	I want to register an account

@RegisterFailure
Scenario Outline: Register with invalid user details
	Given I am on register page
	When I register with "<name>" and "<password>" and "<email>"
	Then I get some "<error>"error
	Examples:
	| name                  | password | email          | error                  |
	| test004               | test004  | test004        | 请输入有效的电子邮件地址           |
	| test004test004test004 | test004  | test004@qq.com | 字符长度必须小于等于18，一个中文字算2个字符 |
	| 004                   | test004  | test004@qq.com | 字符长度必须大于等于4，一个中文字算2个字符 |
	| test004               | test     | test004@qq.com | 最少需要输入 5 个字符    |
	| test004               | test004test004test004test004    | test004@qq.com | 最多只能输入 20 个字符    |

@RegisterFailure
Scenario Outline: Register with captcha code error
	Given I am on register page
	When I can register with "<name>" and "<password>" and "<email>" and "<captcha_code>"
	Then I get some "<error>"error
	Examples:
	| name    | password | email          | captcha_code | error     |
	| test004 | Test004  | test004@qq.com |     1234     | 验证码错误 |
	| test004 | Test004  | test004@qq.com |              | 请输入验证码 |

