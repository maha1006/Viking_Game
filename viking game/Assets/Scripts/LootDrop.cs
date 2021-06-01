using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootDrop : MonoBehaviour
{


    public GameObject[] LootModel;
    public Transform transform;

    public void DropLoot()
    {
        Vector3 position = transform.position;
        //GameObject loot = Instantiate(LootModel, position + new Vector3(0.0f, 4.0f, 0.0f), Quaternion.identity);
        //GameObject loot2 = Instantiate(LootModel, position + new Vector3(2.0f, 4.0f, 0.0f), Quaternion.identity);
        //GameObject loot3 = Instantiate(LootModel, position + new Vector3(0.0f, 4.0f, 2.0f), Quaternion.identity);
        
        //loot.SetActive(true);
        //loot2.SetActive(true);
        //loot3.SetActive(true);

        for(int i = 0; i < LootModel.Length; i++)
        {
            // PositionScript posScript = loot[i].GetComponent<PositionScript>();
            GameObject loot = Instantiate(LootModel[i], position + new Vector3(0.0f, 4.0f, 0.0f), Quaternion.identity);
            loot.SetActive(true);
            Debug.Log("loot falls!");
        }
    }

    // void Start()
    //{
    //  if(Random.Range(0f, 1f) > 0.5f)
    //  {
    //      wood.SetActive(true);
    //  }
    //  ...
    //}
    //
}
