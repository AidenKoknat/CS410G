using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            /*
            if (Time.timeScale == 0)
            {
                AudioListener.pause = true;
                SceneManager.UnloadSceneAsync(0);
                Cursor.visible = false;
                Time.timeScale = 1;
                SceneManager.LoadScene(2);
            }
            else
            {
                Time.timeScale = 0;
                AudioListener.pause = false;
               // MenuController.LoadSceneForSavedGame = false;
                SceneManager.LoadScene(0, LoadSceneMode.Additive);
                Cursor.visible = true;
            }
            */
        }
    }
}