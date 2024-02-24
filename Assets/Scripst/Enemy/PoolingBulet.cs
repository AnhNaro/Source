using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingBulet : MonoBehaviour
{
   
    public GameObject Prefabs;
    List<GameObject> pool = new List<GameObject>();
    [SerializeField] int Zise;
    private void Awake()
    {
        for(int i = 0; i < Zise; i++)
        {
            GameObject Clone = Instantiate(Prefabs,this.transform);
            Clone.gameObject.SetActive(false);
            pool.Add(Clone);
        }
    }
    public GameObject Getpool()
    {

        foreach (GameObject go in pool)
        {
            if (!go.activeInHierarchy)
            {
               GameObject tam = go;
                return tam;
            }
        }
        GameObject clone=Instantiate(Prefabs,this.transform);
        clone.gameObject.SetActive(false);
        pool.Add(clone);
        return clone;  
    }
   
}
