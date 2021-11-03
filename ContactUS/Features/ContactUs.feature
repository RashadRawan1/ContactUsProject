Feature: Contact Us
	in order for customers to contact us 
	As a user 
	I want to be able to submit

Background: 
	Given Contact Us page is displayed	

Scenario: Required fields display warnings
	When Zach selects Submit
	Then a 'Valid first name is required.'warnings should display

Scenario: United States is the only country option
	When Zach click on the country drop-down
	Then the country drop down should only display 'United States'

Scenario: Every state displayed in the drop down
	When Zach selects United States as the country
	Then the state drop down should display '<state>' state

	Examples: 
	| state      |
	| California |
	| Minnesota  |

Scenario: Letters are not accepted in the zip code field
	When zach enters 'Rashad' as the first name
	* zach enters 'Rawan' as the last name
	* 'monkeycode137@yahoo.com' as the email
	* '123 fake street' as the address
	* selects United States as the country
	* selects 'Minnesota' as the state
	* enters 'abc' as the zip code
	* selects submit
	Then a 'Zip code required.'warnings should display

Scenario: Submit contact information
	When zach enters 'zach' as the first name
	* zach enters 'levi' as the last name
	* 'monkeycode137@yahoo.com' as the email
	* '123 fake street' as the address
	* selects United States as the country
	* selects 'California' as the state
	* enters '33813' as the zip code
	* selects submit
	Then a 'Thank you for your interest! Once we review your request a representative will be in contact with you.' message should display