using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using UnityEditor.PackageManager;

public class Win : MonoBehaviour
{
   //tao ra va tac dong luc 1 chut..> phai
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Complete();
            win();
        }
    }
    public void Complete()
    {
        if (SceneManager.GetActiveScene().buildIndex > PlayerPrefs.GetInt("Gameplay"))
        {
            PlayerPrefs.SetInt("Gameplay",SceneManager.GetActiveScene().buildIndex);
            Manager.Instance.LockLevel++;
            PlayerPrefs.Save();
        }
    }
    public void win()
    {
        Manager.Instance.WinComplete();
    }
}
