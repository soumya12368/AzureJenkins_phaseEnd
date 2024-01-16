Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: User can place an order
    Given the user is on the Pizza Selection page
    When the user selects a pizza type and quantity
    And clicks on "Add to Cart"
    Then the order should be displayed on the Order Checkout page
    And the total amount should be correct

Scenario: User can complete the order
    Given the user is on the Order Checkout page
    When the user clicks on "Checkout"
    Then the Order Confirmation page should be displayed
    And the order details should be correct
