using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_con : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        //メインカメラ上で　カーソルのあった場所　場所にRayを飛ばす
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            //Rayが当たるオブジェクトがあった場合はそのオブジェクト名をログに表示
            Debug.Log(hit.collider.gameObject.name);
        }

    }
}
