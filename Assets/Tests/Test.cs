using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Test
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestSimplePasses()
    {
        TestTrueOnesCount();
    }
    [Test]
    public void TestTrueOnesCount()
    {
        // Arrange
        QuestionCounter questionCounter = new QuestionCounter();
        bool[] trueOnes = new bool[] { true, false, true, true, false }; // Örnek trueOnes dizisi
        questionCounter.SetTrueOnes(trueOnes);
        int expectedCount = 3; // trueOnes dizisindeki true sayýsý

        // Act
        int trues = questionCounter.CountTrueOnes();

        // Assert
        Assert.AreEqual(expectedCount, trues);
    }

    

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
