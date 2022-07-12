Feature: Make A Purchase

As a customer on the SwagLabs site
I want to select an item and add it to my basket
So that I can checkout and purchase the item

Scenario: A customer can succesfully purchase an item from the store
	Given I am logged in as an authorised customer
	And I have added a backpack to my cart
	And I have clicked the cart button
	And I click the checkout button
	And I have entered my personal information
	When I click the finish button on the overview page
	Then I should be on the checkout complete page and see the checkout complete message