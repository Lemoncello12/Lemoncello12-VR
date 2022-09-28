using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summoner : MonoBehaviour
{
    public GameObject theSummoned;
    public GameObject church;
    public AudioSource audio;
    public bool summoned = false;
    public bool testSummon = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (testSummon == true)
        {
            if (summoned == false)
            {
                audio.Play();
                theSummoned.gameObject.SetActive(true);
                church.gameObject.SetActive(false);
                summoned = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Chicken"))
        {
            if (summoned == false)
            {
                audio.Play();
                theSummoned.gameObject.SetActive(true);
                church.gameObject.SetActive(false);
                summoned = true;
            }
        }

    }
}
