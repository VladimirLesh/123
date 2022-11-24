using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class UICanvas : MonoBehaviour
{
    public GameObject panelDebug;
    public Text countdown;

    private void Awake()
    {
        panelDebug.SetActive(!panelDebug.activeInHierarchy);
    }

    void Start()
    {
        StartCoroutine(StartText());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            panelDebug.SetActive(!panelDebug.activeInHierarchy);
        }
    }

    IEnumerator StartText()
    {
        yield return new WaitForEndOfFrame();
        for (int i = 3; i > 0; i--)
        {
            countdown.text = $"{i}";
            yield return new WaitForSeconds(1);
        }
        countdown.enabled = false;
    }

}
