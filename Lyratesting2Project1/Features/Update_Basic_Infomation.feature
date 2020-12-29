Feature: Update_Basic_Infomation
After I log in my account, I want to update basic information.

@mytag
Scenario Outline: Update Basic information
	Given I am in the  home page
	And I can login my  account
	| username | password |
    | test001  | Test1234 |
	When I update "<realname>" and "<ID>" and "<PhoneNo>" and "<Title>" and "<Personal Website>" and "<WeiBo>" and "<QQ>"
	Then the "<alert_message>" alert_message can be seen
	Examples:
	| realname              | ID                 | PhoneNo     | Title        | Personal Website      | WeiBo             | QQ    | alert_message |
	| Sam | 440402200706231234 | 13800138000 | IT  engineer | http://www.test.co.nz | http://test.co.nz | 12345 | 基础信息保存成功     |
	| SamSamSamSamSamSamSam | 440402200706231234 | 13800138000 | IT  engineer | http://www.test.co.nz | http://test.co.nz | 12345 | 最多只能输入 18 个字符      |
	| Sam | 1234567890 | 13800138000 | IT  engineer | http://www.test.co.nz | http://test.co.nz | 12345 | 请正确输入您的身份证号码      |
	| Sam | 440402200706231234 | phoneno007 | IT  engineer | http://www.test.co.nz | http://test.co.nz | 12345 | 请输入正确的手机号      |
	| Sam | 440402200706231234 | 13800138000 | IT  engineer IT  engineer | http://www.test.co.nz | http://test.co.nz | 12345 | 最多只能输入 24 个字符      |
    | Sam | 440402200706231234 | 13800138000 | IT  engineer | ttp://www.test.co.nz | http://test.co.nz | 12345 | 地址不正确，须以http://或者https://开头。     |
	| Sam | 440402200706231234 | 13800138000 | IT  engineer | http://www.test.co.nz | http//test.co.nz | 12345 | 地址不正确，须以http://或者https://开头。     |
	| Sam | 440402200706231234 | 13800138000 | IT  engineer | http://www.test.co.nz | http://test.co.nz | 12345qq | 请输入正确的QQ号      |