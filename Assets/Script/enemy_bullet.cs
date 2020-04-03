using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bullet : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb=null;
GameObject gameobject;
    enemy script;
    public float speed=10;
    void Start()
    {
         rb=GetComponent<Rigidbody2D>();
         gameobject=GameObject.Find("enemy");
         script=gameobject.GetComponent<enemy>();

          rb.velocity= new Vector2(rb.velocity.x,-speed);

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter2D(Collision2D collision)
{
      if(collision.collider.tag=="wall"){
          Destroy (gameObject);
          script.shootnum--;
      }
      if(collision.collider.tag=="player"){
          Destroy (gameObject);
          script.shootnum--;
          GM.instance.hp_p--;

      }
      
}
}
