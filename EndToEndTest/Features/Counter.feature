Feature: Increment Counter
	As a user
	i want to be able to increment the counter value

	Scenario: Increment Counter value
	Given Counter button is clicked
	When Counter value is 0
	Then Counter value should increment by 1