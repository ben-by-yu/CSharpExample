Feature: Google Search Functionality Test

@SearchGoogle
Scenario: Search keyword Master Chief in google
	Given I am on google serach web page
	When I input search text
	And I click submit button
	Then I should see search result

@LoginOutlook
Scenario: Login outlook
	Given I am on mail web page
	When I input username and password
		| username							| password			|

	Then I should see inbox
