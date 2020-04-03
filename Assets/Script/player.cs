using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public int shootnum=0;
    private Rigidbody2D rb=null;
    public GameObject bullet_p;
    public int SHOOT=5;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed=0;

        float horizontalKey=Input.GetAxis("Horizontal");
        if(horizontalKey>0){
xSpeed=speed;
        }else if(horizontalKey<0){
xSpeed=-speed;
        }else{
            xSpeed=0;
        }
        rb.velocity= new Vector2(xSpeed,rb.velocity.y);
        Vector3 shootpos=new Vector3(0,1,0);
        if (Input.GetKeyDown (KeyCode.Space) &shootnum<SHOOT) {
            shootnum++;
			Instantiate (bullet_p, transform.position+shootpos, Quaternion.identity);
		}
    }
}
