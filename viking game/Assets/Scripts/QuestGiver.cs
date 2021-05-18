using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestGiver : MonoBehaviour
{
    public Quest quest;

    public Player player;

    public GameObject questWindow;
    public Text titleText;
    public Text descriptuionText;

    public void OpenQuestWindow()
    {
        questWindow.SetActive(true);
        titleText.text = quest.title;
        descriptuionText.text = quest.description;
    }
}
