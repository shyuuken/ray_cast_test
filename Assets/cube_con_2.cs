using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_con_2 : MonoBehaviour
{

    // Use this for initialization
    void Start() { }

    //クリックしたオブジェクトを消す
    void OnMouseDown()
    {
        Destroy(this.gameObject,0.5f);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
