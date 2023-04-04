using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathMenu : MonoBehaviour
{
    public PlayerController Player;
    public Image deathScreen;
    //public Text DeathText;
    //public bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        deathScreen.enabled = false;
        //DeathText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.isDead == true)
        {
            deathScreen.enabled = true;
            //DeathText.enabled = true;
        }
        else
        {
            deathScreen.enabled = false;
            //DeathText.enabled = false;
        }
        
    }
}
