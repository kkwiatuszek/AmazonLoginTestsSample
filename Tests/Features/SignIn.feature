Feature: SignInPage
	In order to view my basket
	As a user
	I want to log in to my amazon account


Background: 
	Given I navigate to log in page for amazon

Scenario Outline: SignIn - Valid submission
	When I enter <valid email>  to email input
	And I enter <valid password> to password input
	And I click submit button
	Then I am redirected to home page as a logged user
	Examples: 
	| valid email				 | valid password	|
	| testforamazonkk@gmail.com  | zxcvbnm			|

Scenario Outline: SignIn - Invalid submission
	When I enter <invalid email>  to email input
	And I enter <invalid password> to password input
	And I click submit button
	Then an error message is displayed for email
	Examples: 
	| invalid email	 | invalid password |
	| wrong@mail.com | wrongpassword    |

Scenario Outline: SignIn - Valid email, invalid password submission
	When I enter <valid email>  to email input
	And I enter <invalid password> to password input
	And I click submit button
	Then an error message is displayed for password
	Examples: 
	| valid email				| invalid password	|
	| testforamazonkk@gmail.com | wrongpassword		|

Scenario Outline: SignIn - Invalid email, valid password submission
	When I enter <invalid email>  to email input
	And I enter <valid password> to password input
	And I click submit button
	Then an error message is displayed for email
	Examples: 
	| invalid email		| valid password | 
	| wrong@mail.com	| zxcvbnm     |

Scenario Outline: SignIn - Invalid email, password left empty
	When I enter <valid email>  to email input
	And I leave password empty
	And I click submit button
	Then an error message is displayed for empty password
	Examples: 
	| valid email				 |
	| testforamazonkk@gmail.com  |

Scenario: SignIn - Empty inputs submission 
	When I click submit button
	Then an error message is displayed for both inputs