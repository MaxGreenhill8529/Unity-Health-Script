using NUnit.Framework;
using UnityEngine.TestTools;
using System.Collections;

public class HealthTester
{
  [Test]
  public void HealthTesterSimplePasses(){}

  [UnityTest]
  public IEnumerator HealthTesterWithEnumeratorPasses()
  {
    yield return null;
  }
}
