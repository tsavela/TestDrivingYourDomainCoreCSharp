using Domain.BDDTests.Data;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.xUnit.SpecFlowPlugin;

namespace Domain.BDDTests.StepDefinitions
{
    [Binding]
    public class ShoppingCartSteps
    {
        private readonly ShoppingCartData _shoppingCartData;

        public ShoppingCartSteps(ShoppingCartData shoppingCartData)
        {
            _shoppingCartData = shoppingCartData;
        }

        [Given(@"the empty shopping cart")]
        public void GivenTheEmptyShoppingCart()
        {
            throw new XUnitPendingStepException();
        }

        [Then(@"the shopping cart is empty")]
        public void ThenTheShoppingCartIsEmpty()
        {
            throw new XUnitPendingStepException();
        }

        [When(@"I add the following item:")]
        public void WhenIAddTheFollowingItem(Table itemsTable)
        {
            throw new XUnitPendingStepException();
        }

        [Then(@"the shopping cart contains (.*) item")]
        public void ThenTheShoppingCartContainsItem(int numberOfItems)
        {
            throw new XUnitPendingStepException();
        }

        [Then(@"the first item is ""(.*)""")]
        public void ThenTheFirstItemIs(string itemName)
        {
            throw new XUnitPendingStepException();
        }

        [Given(@"the shopping cart contains the following items:")]
        public void GivenTheShoppingCartContainsTheFollowingItems(Table itemsTable)
        {
            throw new XUnitPendingStepException();
        }

        [When(@"I remove the following item:")]
        public void WhenIRemoveTheFollowingItem(Table itemsTable)
        {
            throw new XUnitPendingStepException();
        }

        [When(@"I proceed to check out")]
        public void WhenIProceedToCheckOut()
        {
            throw new XUnitPendingStepException();
        }

        [Then(@"the following order with a total amount due of (.*) is created:")]
        public void ThenTheFollowingOrderWithATotalAmountDueOfIsCreated(string totalAmount, Table itemsTable)
        {
            throw new XUnitPendingStepException();
        }
    }
}
