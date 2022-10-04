using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // A combination of SimulatorToogle and SceneOpener, with more likely to come.
    public GameObject simulator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift) && !simulator.gameObject.activeSelf)
        {
            simulator.gameObject.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.RightShift) && simulator.gameObject.activeSelf)
        {
            simulator.gameObject.SetActive(false);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenScene(int sceneNum)
    {
        //Debug.Log("It worked!");
        SceneManager.LoadScene(sceneNum);
    }
}
