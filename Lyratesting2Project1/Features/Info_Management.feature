Feature: Info_Management
	In order to do some information and category management
	As an adminstrator
	I want to search information with multiple filters or edit categories

@InfroManagement
Scenario Outline: Search inforamtion with mutiple filters
	Given I am on the Information Management Page
	| username | password     |
    | admin    | 5EstafeyEtre |
	When I want to do some searchs with multiple filters such as "<category>" and "<keyword>" and "<property>" and "<status>"
	Then the <search_result> search result should match the expected result
	Examples:
	| category | keyword | property | status | search_result |
	| 行业资讯  |         |          |        | 8             |
	| 行业资讯  | MOOC    |          |        | 5             |
	| EduSoho1 | new     | 头条     | 已发布  | 1             |
	| EduSoho1 | new1    | 头条     | 已发布  | 0             |

@InfroManagement
Scenario:  Changing the status of an article
    Given I am on the Information Management Page 
	| username | password     |
    | admin    | 5EstafeyEtre |
	When I want to change the status of an article
	Then the UI should be updated accordingly

@CategoryManagement
Scenario Outline:  Adding a category on Info Management Page
    Given I am on the Information Management Page 
	| username | password     |
    | admin    | 5EstafeyEtre |
	When I want to add a new category "<category_name>" and "<category_code>" and "<parent_category>" and "<SEO_title>" and "<SEO_keyword>" and "<SEO_description>" on Info Management Page
	Then the new category can be added and reflected on the UI
	Examples:
	| category_name | category_code | parent_category | SEO_title   | SEO_keyword | SEO_description  |
	| Testcategory  | test123       | 行业资讯         | test1235678 | test        | test123567890000 |

@CategoryManagement
Scenario: Editing the category
   Given I am on the Information Management Page
	| username | password     |
    | admin    | 5EstafeyEtre |
   When I want to change the category name
   | expected_category_name |
   | Testcategory123        |
   Then the new category name is reflected on the UI


