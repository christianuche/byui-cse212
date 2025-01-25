using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        // In arrange: Create a new PriorityQueue instance
        var priorityQueue = new PriorityQueue();

        // Action: Enqueue some items with different priorities
        priorityQueue.Enqueue("Low", 1); // Low priorities
        priorityQueue.Enqueue("Medium", 3); // Medium priorities
        priorityQueue.Enqueue("High", 5); // High priorities

        // Assertion: Verify that the highest priority item ("High") is actually dequeued first
        var dequeuedItem = priorityQueue.Dequeue();
        Assert.AreEqual("High", dequeuedItem); // First dequeued should be "High"

        // Assertion: Verify that the next item dequeued is "Medium"
        dequeuedItem = priorityQueue.Dequeue();
        Assert.AreEqual("Medium", dequeuedItem); // Second dequeued should be "Medium"

        // Assertion: Verify that the next item dequeued is "Low"
        dequeuedItem = priorityQueue.Dequeue();
        Assert.AreEqual("Low", dequeuedItem); // The last dequeued should be "Low"

        //Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        // Arranging: Create a new PriorityQueue instance
        var priorityQueue = new PriorityQueue();

        // Actions & Assertions: Try to dequeue from an empty queue and catch the exception
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown for empty queue.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message); // Exception message should match
        }
        //Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}