using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // load Cantina scene
    public void CantinaSelect()
    {
        SceneManager.LoadScene(1);
    }

    // load Cube scene
    public void CubeSelect()
    {
        SceneManager.LoadScene(2);
    }

    // load LivingRoom scene
    public void LivingRoomSelect()
    {
        SceneManager.LoadScene(0);
    }

    // load Mezzanine scene
    public void MezzanineRoomSelect()
    {
        SceneManager.LoadScene(3);
    }
}
