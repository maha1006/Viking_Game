using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UpgradeBoat : MonoBehaviour
{

    public GameObject Default;
    public GameObject Upgraded;

    public QuestTaker questTaker;
    void Start()
    {
        Default.gameObject.SetActive(true);

        Upgraded.gameObject.SetActive(false);
    }
    public void Upgrade()
    {
        Default.gameObject.SetActive(false);
        Upgraded.gameObject.SetActive(true);
        questTaker.questWindowReached.SetActive(false);
    }

}
