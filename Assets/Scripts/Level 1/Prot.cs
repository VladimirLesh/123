using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prot : MonoBehaviour
{
    [SerializeField] private GameObject prot;
    [SerializeField] private GameObject boomProt;
    private GameObject ps;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Подсчет отчев протеина
            GameManager.GM.ProtCoint++;
            // эффект рассыпания протеина
            ps = Instantiate(boomProt, transform.position, boomProt.transform.rotation);
            Destroy(prot);
            Destroy(ps, 0.5f);
        }
    }
}
