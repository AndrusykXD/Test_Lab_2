Feature: Withdraw Money

  Scenario: Withdraw money from the account
    Given I am on the banking website
    When I select "Login as User" option
    And I select "Hermoine Granger" as a customer
    And I click Login button
    Then I should be on the bank's home page
    When I click the Withdrawl button
    And I enter the withdrawal amount as full sum / 2
    And I click the "Confirm Withdrawal" button
    Then I should see a success message
    When I enter the withdrawal amount as full sum x 2
    And I click the "Confirm Withdrawal" button again
    Then I should see an error message
    Then I should close Chrome