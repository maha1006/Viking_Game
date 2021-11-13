using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rammbock2 : MonoBehaviour
{

    public GameObject WindowUpgraded;
    public GameObject WindowNotUpgraded;
    public GameObject RammbockUpgrade;
    public GameObject Trigger;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (RammbockUpgrade.gameObject.activeInHierarchy == false)
            {
                WindowUpgraded.SetActive(true);
            }
            else
            {
                WindowNotUpgraded.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (RammbockUpgrade.gameObject.activeInHierarchy == true)
            {
                Trigger.GetComponent<CapsuleCollider>().enabled = false;
                CloseQuestWindow();
            }
            else
            {
                CloseQuestWindow();
            }
        }
        
    }

    public void CloseQuestWindow()
    {
        WindowNotUpgraded.SetActive(false);
        WindowUpgraded.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
