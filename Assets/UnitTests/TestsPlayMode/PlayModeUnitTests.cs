using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayModeUnitTests
{
    private GameObject testObj;
    private Vector3 startPos;
    

    [SetUp]
    public void SetUp()
    {
        testObj = GameObject.Instantiate(new GameObject());
        testObj.AddComponent<TestBehaviour>();
        startPos = testObj.transform.position;
    }
    [UnityTest]
    public IEnumerator UnitTest_isObjectIsNotNull()
    {
        
        yield return new WaitForSeconds(0.1f);

        Assert.IsNotNull(testObj);
    }
    [UnityTest]
    public IEnumerator UnitTest_isRBNoyNull()
    {

        yield return new WaitForSeconds(0.1f);

        Assert.IsNotNull(testObj.GetComponent<Rigidbody>());
    }

    [UnityTest]
    public IEnumerator UnitTest_isIsNotNull()
    {

        yield return new WaitForSeconds(0.1f);

        Assert.IsNotNull(testObj.GetComponent<TerrainCollider>());
    }

    [UnityTest]
    public IEnumerator UnitTest_()
    {

        yield return new WaitForSeconds(0.1f);

        Vector3 currPos = testObj.transform.position;

        Assert.AreNotEqual(startPos, currPos);
    }
}
