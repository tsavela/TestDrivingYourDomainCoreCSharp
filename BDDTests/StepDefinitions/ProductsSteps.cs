using Domain.BDDTests.Data;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.xUnit.SpecFlowPlugin;

namespace Domain.BDDTests.StepDefinitions
{
    [Binding]
    public class ProductsSteps
    {
        private readonly ProductsData _productsData;

        public ProductsSteps(ProductsData productsData)
        {
            _productsData = productsData;
        }

        [Given(@"the following available products:")]
        public void GivenTheFollowingAvailableProducts(Table productsTable)
        {
            // Example: _productsData.Products = productsTable.CreateSet<Product>();
            throw new XUnitPendingStepException();
        }
    }
}
