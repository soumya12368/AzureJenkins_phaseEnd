using System;
using TechTalk.SpecFlow;
using PizzaOrderingLibrary;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class PizzaOrderingStepDefinitions
    {
        private readonly PizzaSelectionData _pizzaSelectionData;
        private readonly OrderCheckoutData _orderCheckoutData;
        private readonly OrderConfirmationData _orderConfirmationData;

        public PizzaOrderingStepDefinitions(PizzaSelectionData pizzaSelectionData, OrderCheckoutData orderCheckoutData, OrderConfirmationData orderConfirmationData)
        {
            _pizzaSelectionData = pizzaSelectionData;
            _orderCheckoutData = orderCheckoutData;
            _orderConfirmationData = orderConfirmationData;
        }

        [Given(@"the user is on the Pizza Selection page")]
        public void GivenTheUserIsOnThePizzaSelectionPage()
        {
            // Implement logic to navigate to the Pizza Selection page
            Console.WriteLine("User is on the Pizza Selection page.");
        }

        [When(@"the user selects a pizza type and quantity")]
        public void WhenTheUserSelectsAPizzaTypeAndQuantity()
        {
            // Implement logic to select a pizza type and quantity
            _pizzaSelectionData.SelectedPizzaType = "Pepperoni";
            _pizzaSelectionData.Quantity = 2;
            Console.WriteLine($"User selected {_pizzaSelectionData.Quantity} {_pizzaSelectionData.SelectedPizzaType} pizza(s).");
        }

        [When(@"clicks on ""([^""]*)""")]
        public void WhenClicksOn(string button)
        {
            // Implement logic to click on the specified button (e.g., "Add to Cart" button)
            Console.WriteLine($"User clicks on \"{button}\".");
        }

        [Then(@"the order should be displayed on the Order Checkout page")]
        public void ThenTheOrderShouldBeDisplayedOnTheOrderCheckoutPage()
        {
            // Implement logic to verify that the order is displayed on the Order Checkout page
            var orderItem = new OrderItemData
            {
                PizzaType = _pizzaSelectionData.SelectedPizzaType,
                Quantity = _pizzaSelectionData.Quantity,
                Price = 10.0m // Replace with the actual price based on your logic
            };
            Console.WriteLine($"Order displayed on the Order Checkout page: {orderItem.Quantity} {orderItem.PizzaType} pizza(s).");
        }

        [Then(@"the total amount should be correct")]
        public void ThenTheTotalAmountShouldBeCorrect()
        {
            // Implement logic to verify that the total amount is correct
            Console.WriteLine($"Total amount is {_orderCheckoutData.TotalAmount:C}.");
        }

        [Given(@"the user is on the Order Checkout page")]
        public void GivenTheUserIsOnTheOrderCheckoutPage()
        {
            // Implement logic to navigate to the Order Checkout page
            Console.WriteLine("User is on the Order Checkout page.");
        }

        [When(@"the user clicks on ""([^""]*)""")]
        public void WhenTheUserClicksOn(string button)
        {
            // Implement logic to click on the specified button (e.g., "Checkout" button)
            Console.WriteLine($"User clicks on \"{button}\".");
        }

        [Then(@"the Order Confirmation page should be displayed")]
        public void ThenTheOrderConfirmationPageShouldBeDisplayed()
        {
            // Implement logic to verify that the Order Confirmation page is displayed
            Console.WriteLine("Order Confirmation page is displayed.");
        }

        [Then(@"the order details should be correct")]
        public void ThenTheOrderDetailsShouldBeCorrect()
        {
            // Implement logic to verify that the order details are correct on the Order Confirmation page
            Console.WriteLine($"Order details are correct: Order ID - {_orderConfirmationData.OrderId}, Amount - {_orderConfirmationData.Amount:C}, Pizza Type - {_orderConfirmationData.PizzaType}.");
        }
    }
}
