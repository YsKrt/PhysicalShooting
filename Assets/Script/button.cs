using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    private bool firstPush = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void click(){
Debug.Log("Press Start!");
          if (!firstPush)
          {
              SceneManager.LoadScene("game");
              firstPush = true;
          }
    }
}
