using LinkedListProblem;
namespace LinkedListTest
{
    public class Tests
    {
        LinkedList linkedList = new LinkedList();
        Random random = new Random();

        [Test]
        public void DoesSearchValueFunctionReturnTrue_IfValueGivenIsPrsentInList()
        {
            for (int i = 0; i <= random.Next(1, 5); i++)
                linkedList.Add(random.Next(10, 99));

            linkedList.Append(78);

            for (int i = 0; i <= random.Next(1, 5); i++)
                linkedList.Add(random.Next(10, 99));

            bool doesExist = linkedList.SearchValue(78);

            Assert.AreEqual(true, doesExist);
            Assert.Pass();
        }
        [Test]
        public void DoesSearchValueFunctionReturnFalse_IfValueGivenIsNotPrsentInList()
        {
            for (int i = 0; i <= random.Next(1, 5); i++)
                linkedList.Add(random.Next(10, 99));

            linkedList.Append(78);

            for (int i = 0; i <= random.Next(1, 5); i++)
                linkedList.Add(random.Next(10, 99));

            bool doesExist = linkedList.SearchValue(9);

            Assert.AreEqual(false, doesExist);
            Assert.Pass();
        }
    }
}