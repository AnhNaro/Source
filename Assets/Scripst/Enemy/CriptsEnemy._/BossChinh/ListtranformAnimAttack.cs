using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListtranformAnimAttack : MonoBehaviour
{
    public List<Transform> tran = new List<Transform>();
    public void EnableGamtran1()
    {
        tran[0].gameObject.SetActive(true);
    }
    public void EnableGamtran2()
    {
        tran[1].gameObject.SetActive(true);
    }
    public void EnableGamtran3()
    {
        tran[2].gameObject.SetActive(true);
    }
    public void EnableGamtran4()
    {
        tran[3].gameObject.SetActive(true);
    }
    public void EnableGamtran5()
    {
        tran[4].gameObject.SetActive(true);
    }
  
    //false
    public void MoveGamtran1()
    {
        tran[0].gameObject.SetActive(false);
    }
    public void MoveGamtran2()
    {
        tran[1].gameObject.SetActive(false);
    }
    public void MoveGamtran3()
    {
        tran[2].gameObject.SetActive(false);
    }
    public void MoveGamtran4()
    {
        tran[3].gameObject.SetActive(false);
    }
    public void MoveGamtran5()
    {
        tran[4].gameObject.SetActive(false);
    }
  
}
