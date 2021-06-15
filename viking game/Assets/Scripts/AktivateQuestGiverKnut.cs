using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AktivateQuestGiverKnut : MonoBehaviour
{
    public Quest quest;
    public QuestGiver questgiver;
    public void Activate()
    {
        if (questgiver.quest.isActive)
        {
            Debug.Log(" active");
            if (quest.isActive)
            {
                this.gameObject.SetActive(true);
                Debug.Log(" reached");
            }

        }
    }
}