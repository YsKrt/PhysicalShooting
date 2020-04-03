using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public static GM instance = null;
    public int hp_e=10;
    public int hp_p=10;
    public int win_e=0;
    public int win_p=0;
    void Awake(){
        if(instance == null)
         {
             instance = this;
             DontDestroyOnLoad(this.gameObject); 
         }
         else
         {
             Destroy(this.gameObject);
         }
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.Escape)) {
             Quit();
  }
    }
   void Quit(){
       #if UNITY_EDITOR
      UnityEditor.EditorApplication.isPlaying = false;
    #elif UNITY_STANDALONE
      UnityEngine.Application.Quit();
    #endif
   }
    void OnApplicationQuit()
    {
        Debug.Log("しゅうりょうしたよ");
        Destroy(this.gameObject);
    }
}
