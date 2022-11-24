using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClass
{
    private int testVal;

    public TestClass(int val)
    {
        this.testVal = val + 1;
    }

    public int GetCurrrentVal()
    {
        return testVal;
    }

    public int AddFive()
    {
        return this.testVal + 5;
    }
}
