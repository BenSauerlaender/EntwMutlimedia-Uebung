using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [SerializeField] private GameObject menu;
    private bool pause = false;

    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
        pause = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            pause = !pause;
            if (pause){
                menu.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                menu.SetActive(false);
                Time.timeScale = 1;
            }
        }

    }

    public void resume()
    {
        pause = false;
        menu.SetActive(false);
        Time.timeScale = 1;
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
