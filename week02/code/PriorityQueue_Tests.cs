using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: add items with different priorities and ensure the highest priority is dequeued first.
    // Expected Result: Dequeeu returns the item with the highest priority
    // Defect(s) Found: the loop skips the last element in the queue
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);

        var dequeued = priorityQueue.Dequeue();
        Assert.AreEqual("B", dequeued, "the item with the highest priority was not dequeued.");
    }

    [TestMethod]
    // Scenario: add items with the same priority and ensure FIFO is maintained
    // Expected Result: the first itme added among those with the highest priority is dequeued first
    // Defect(s) Found: Fifo not maintained for equal priority
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);
    

        var dequeued = priorityQueue.Dequeue();
        Assert.AreEqual("A", dequeued, "FIFO is not maintained for items with the same priority.");
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Dequeue from an empty queue
    // Expected Result: An InvalidOperationException is thrown
    // Defect(s) Found: None
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        // Assert that Dequeue throws an InvalidOperationException when the queue is empty
        Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue(),
            "Dequeue did not throw an exception for an empty queue."
        );
    }


    [TestMethod]
    // Scenario: add multiple items to verify the queue handles priority correctly
    // Expected Result: Items are dequeued in the order of highest priority
    // Defect(s) Found: 
public void TestPriorityQueue_4()
{
    var priorityQueue = new PriorityQueue();

    // Enqueue items with different and same priorities
    priorityQueue.Enqueue("A", 1);
    priorityQueue.Enqueue("B", 3);
    priorityQueue.Enqueue("C", 5);
    priorityQueue.Enqueue("D", 3);

    // Assert that the highest priority item is dequeued first
    Assert.AreEqual("C", priorityQueue.Dequeue(), "First dequeue failed.");

    // Assert that items with the next highest priority are dequeued in FIFO order
    Assert.AreEqual("B", priorityQueue.Dequeue(), "Second dequeue failed.");
    Assert.AreEqual("D", priorityQueue.Dequeue(), "Third dequeue failed.");

    // Assert that the remaining item is dequeued last
    Assert.AreEqual("A", priorityQueue.Dequeue(), "Fourth dequeue failed.");

    // Assert that dequeuing an empty queue throws an exception
    Assert.ThrowsException<InvalidOperationException>(
        () => priorityQueue.Dequeue(),
        "Dequeue did not throw an exception for an empty queue."
    );
}
}