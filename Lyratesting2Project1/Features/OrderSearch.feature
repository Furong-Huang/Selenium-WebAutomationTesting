Feature: OrderSearch
	In order to have a view the orders' situation
	As an administrator of EduSoho
	I want to do course search and class search based on some conditions

@OrderSearch
Scenario Outline:Course Order Search
	Given I am on the order page
    | username | password     |
    | admin    | 5EstafeyEtre |
	When I can do course search based on some conditions such as "<date>" and "<status>" and "<payment_method>" and "<keyword_type>" and "<keyword_content>"
	Then the <order_result> order_result can be seen
	Examples: 
	| date             | status | payment_method | keyword_type | keyword_content      | order_result |
	|                  |        |                |              |                      | 20           |
	| 2015-06-11 10:57 | 已付款    |                | 订单号          | C2015061110570175312 | 1            |
	| 2018-06-11 12:24 | 已付款    |                | 购买者用户名       | t22222               | 2            |
	|                  | 已付款    | 支付宝            |              |                      | 0            |
	| 2015-06-02 15:14 | 已付款    |                | 课程名称         | 购买课程《ES特色功能--班级》     | 1            |

@OrderSearch
Scenario Outline:Class Order Search
	Given I am on the order page
    | username | password     |
    | admin    | 5EstafeyEtre |
	When I can do class search based on some conditions such as "<date>" and "<status>" and "<payment_method>" and "<keyword_type>" and "<keyword_content>"
	Then the <order_result> order_result can be seen
	Examples: 
	| date             | status | payment_method | keyword_type | keyword_content       | order_result |
	|                  |        |                |              |                       | 5            |
	| 2015-06-30 16:59 | 已付款    | 站外支付           | 订单号          | CR2015063016591966296 | 1            |
	| 2018-06-11 11:15 | 已付款    |                | 购买者用户名       | t22222                | 1            |
	| 2015-06-30 16:59 | 已付款    | 站外支付           | 班级名          | EduSoho产品介绍           | 2            |
	| 2015-06-30 16:59 | 已付款    | 站外支付           | 购买者用户名       | River                 | 1            |
