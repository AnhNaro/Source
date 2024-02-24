using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSkill : MonoBehaviour
{
    [SerializeField] float timeon;
    [SerializeField] float timeskill;
    [SerializeField] Text skillText;
    [SerializeField] GameObject imageskill;
    int playerskill;
    void Start()
    {
        timeon = timeskill;
    }

    // Update is called once per frame
    void Update()
    {
        if(!imageskill.gameObject.activeInHierarchy)
        {
            timeskill-=Time.deltaTime;
            playerskill=(int)timeskill;
        }
        skillText.text=playerskill.ToString();
        if(playerskill<=0)
        {
            imageskill.SetActive(true);
        }
        if(imageskill.gameObject.activeInHierarchy)
        {
            timeskill = timeon;
        }
    }
 
}
