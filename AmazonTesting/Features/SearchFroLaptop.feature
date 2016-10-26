Feature: SearchFroLaptop
	Background:
    Given I navigate to "https://www.amazon.com/"
    And I select "Computers" from the dropdown menu next to the search bar

    Scenario Outline:
      When I type "<text>" in the search bar
      And I select first suggestion from auto-complete
      Then I should see results 

      Examples:
      |text|
      |laptop|
      |camera|
      |Ipad|
