Feature: Your Cart

As a customer on the SwagLabs site
I want to be able to manage my basket
So that I can proceed with my order

Scenario: A customer can remove an item from their basket
	Given I am logged in as an authorised customer
	And I have added a backpack to my cart
	And I have clicked the cart button
	When I click the backpack remove button
	Then my cart should be empty

Scenario: A customer can return to the Products page
	Given I am logged in as an authorised customer
	And I have added a backpack to my cart
	And I have clicked the cart button
	When I click the continue shopping button
	Then I am taken to the Products page

Scenario: A customer can proceed to the Your Information page
	Given I am logged in as an authorised customer
	And I have added a backpack to my cart
	And I have clicked the cart button
	When I click the checkout button
	Then I am taken to the Your Information page

Scenario: A customer cannot proceed to the Your Information page if their cart is empty
	Given I am logged in as an authorised customer
	And I have added a backback to my cart
	And I have clicked the cart button
	And I click the remove button
	When I click the checkout button
	Then I am not taken to the Your Information page
	
Scenario: A customer can logout from Your Cart page
	Given I am logged in as an authorised customer
	And I have added a backpack to my cart
	And I have clicked the cart button
	When I click the logout button
	Then I am successfully logged out

Scenario: A customer can navigate to the Secret Sauce twitter page
	Given I am logged in as an authorised customer
	And I have added a backpack to my cart
	When I click the cart button
	Then I can see a link to the Secret Sauce twitter page