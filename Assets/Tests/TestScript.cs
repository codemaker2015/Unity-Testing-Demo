using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestScript
    {
        // A Test behaves as an ordinary method
        [Test]
        public void TestScriptSimplePasses()
        {
            // Use the Assert class to test conditions
            Assert.IsNotNull(GameObject.Find("Main Camera"));
            Assert.AreNotSame(GameObject.Find("Main Camera"), GameObject.Find("AR Camera"));
            // Assert.AreEqual(GameObject.Find("Main Camera"), GameObject.Find("Main Camera"));

            Assert.Throws<System.InvalidOperationException>(
            () => { GameObject _ = GameObject.Find("Main Camera"); },
            "Cannot find Camera gameobject");
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
