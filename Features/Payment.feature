Feature: Payment
	Users should be able to select a method of payment
    So that they may be able to pay for their products.Existing address /Success card
	

@mytag
Scenario: Valid Test: Payment using Paystack/Homedelivery/Success card
Given a registered user navigate to "https://longrichway.com/"
	When a user click COUNTRY
	And a user click COUNTRY TYPE
	And a user click sign in
	And a user enter email "tester@yahoo.com"
	And a user type password "drone"
	And a user click login
	And a user click categories
	And a userclick faminine care
	And a user click featured Product
	And a user enter quantity "13"
	And a user click add to cart
	And a user click cart
	And a user click view cart
	And a user click proceed checkout
	And a user click pay stack
	And a user click home delivery
	And a user click existing address
	And a user enter comment "Thank you!"
	And a user click complete order
	And a userclick on success card
	And a user click pay
	Then payment notification apperated "payment made successfully"




