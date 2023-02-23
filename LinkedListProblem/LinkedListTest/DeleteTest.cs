using LinkedListProblem;
using System.Collections.Generic;

namespace LinkedListTest
{
    public class DeleteTest
    {
        LinkedList linkedList = new LinkedList();
        [Test]
        public void CheckingIfTheValueGivenIsRemoved()
        {
            linkedList.Add(56); linkedList.Add(30);linkedList.Add(40); linkedList.Add(70);
            Assert.AreEqual("56->30->70->", linkedList.Delete(40));
        }
    }
}
