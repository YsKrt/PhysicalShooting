using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject obj_e;
    enemy scr_e;
    GameObject obj_p;
    player scr_p;

    void Start()
    {
        obj_e=GameObject.Find("enemy");
         scr_e=obj_e.GetComponent<enemy>();
         obj_p=GameObject.Find("player");
         scr_p=obj_p.GetComponent<player>();
         
    }

    // Update is called once per frame
    void Update()
    {
        if(GM.instance.hp_e<=0 ||GM.instance.hp_p<=0){
              if(GM.instance.hp_e<=0){
                GM.instance.win_p++;
            }
            if(GM.instance.hp_p<=0){
                GM.instance.win_e++;
            }
            GM.instance.hp_e=10;
            GM.instance.hp_p=10;
          
  
            scr_p.transform.position=new Vector3(320,380,0);
            scr_e.transform.position=new Vector3(345,360,0);
            scr_p.shootnum=0;
            scr_e.shootnum=0;
            var clones = GameObject.FindGameObjectsWithTag ("bullet");
foreach (var clone in clones){
    Destroy(clone);
}

        }
    }
}
