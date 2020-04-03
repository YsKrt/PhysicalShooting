using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // 追加しましょう

public class e_score : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject score_object = null;
    public int hp;
    public int win;
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hp=GM.instance.hp_e;
        win=GM.instance.win_e;
        Text score_text=score_object.GetComponent<Text>();
        score_text.text = "Enemy hp:"+hp+" win:"+win;
    }
}
