using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{


    public float speed;
    int time=0;
    public int shootnum=0;
    public GameObject bullet_e;
    private Rigidbody2D rb=null;
      public  int SHOOT=5;    
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    float xSpeed=0;
    void Update()
    {
        
    
        time++;
        int rnd=Random.Range(1,50);
        if(time%rnd==0){
            int rnd2=Random.Range(1,30);
            if(rnd2<30/2){
                xSpeed=-speed;
            }else if(rnd2>30/2){
                xSpeed=speed;
            }else{
                xSpeed=0;
            }
        }
        if(time%30==rnd & shootnum<SHOOT){
            shootnum++;
            Vector3 shootpos=new Vector3(0,-1,0);
            Instantiate (bullet_e, transform.position+shootpos, Quaternion.identity);
        }
        rb.velocity= new Vector2(xSpeed,rb.velocity.y);
    }
}
