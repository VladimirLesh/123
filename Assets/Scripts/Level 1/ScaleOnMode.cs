using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleOnMode : MonoBehaviour
{
    public void ScaleUp(bool b)
    {
        StaticBoolChangies.isScaleOn = b;
    }
}
