using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawpooBo : MonoBehaviour
{
    public List<GameObject> Spawns=new List<GameObject>();
    float DemG;
    Vector2 Vitri;
    Vector2 ita;
    public GameObject Prefabs;
    public Transform A;
    public GameObject NothuatThuc;
    // Start is called before the first frame update
    private void Awake()
    {
        GameObject Clon=Instantiate(NothuatThuc,transform.position,Quaternion.identity);
    }
    void Start()
    {
       transform.localScale = PlayerControler.instance.transform.localScale;
    }
    private void FixedUpdate()
    {
        ita = A.position - transform.position;
        Vitri = Spawns[Random.Range(0, Spawns.Count)].transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        DemG += Time.deltaTime;
        if (DemG > 0.3f)
        {
            Shoot();
            DemG = 0;
        }
    }
    public void Shoot()
    {
        GameObject Go = Instantiate(Prefabs, Vitri, Quaternion.identity);
        Go.TryGetComponent(out MoveSkill ski);
        ski.SetH(ita);
    }
}
