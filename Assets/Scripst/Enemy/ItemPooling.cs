using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPooling : MonoBehaviour
{
    public List<GameObject> item=new List<GameObject>();
   public GameObject Getitempooling()
    {
        GameObject Cloneitem = item[Random.Range(0, item.Count)];
        return Cloneitem;
    }
}
