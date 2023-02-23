using LinkedListProblem;
namespace LinkedListTest
{
    public class AddingValueAfterNodeTest
    {
        LinkedList linkedlist = new LinkedList();
        [Test]
        public void InsertingDataAfterParticularData()
        {
            linkedlist.Add(56);linkedlist.Add(30);linkedlist.Add(70);

            Assert.AreEqual("56->30->40->70->", linkedlist.InsertValueAfter(40, 30));

        }
    }
}
