using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulatorToogle : MonoBehaviour
{
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
}
