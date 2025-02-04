Feature: ABN Lookup Search
  As a user of the ABN Lookup website,
  I want to search for businesses using ABN, ACN, or name
  So that I can retrieve relevant business details.

  Scenario: Search for a business using ABN
    Given I navigate to the ABN Lookup website
    When I enter the ABN "51824753556"
    And I click on the search button
    Then I should see the business name "AUSTRALIAN TAXATION OFFICE"

  Scenario: Search for a business using ACN
    Given I navigate to the ABN Lookup website
    When I enter the ACN "000000019"
    And I click on the search button
    Then I should see the business name "MONAKA PTY LTD"

  Scenario: Search for a business using a name
    Given I navigate to the ABN Lookup website
    When I enter the business name "Microsoft"
    And I click on the search button
    Then I should see results related to "Microsoft"
