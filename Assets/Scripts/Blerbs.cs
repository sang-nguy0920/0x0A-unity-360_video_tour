using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blerbs : MonoBehaviour
{
    public GameObject blerbtext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // toggle blerbs
    public void ToggleBlerbs()
    {
        if (blerbtext.activeSelf)
        {
            blerbtext.SetActive(false);
        }
        else
        {
            blerbtext.SetActive(true);
        }
    }
}
