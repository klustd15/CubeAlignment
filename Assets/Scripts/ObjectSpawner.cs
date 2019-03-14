using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectSpawner : MonoBehaviour {
    private int cnt;
    public GameObject Prefab;
    // Use this for initialization
	void Start () {
        cnt = 0;
	}
	
	void FixedUpdate () {
        if (Input.GetKeyDown(KeyCode.G))
        {
            /* LEGACY CODE
               GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
               cube.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 10;
               Material mat = null;
               if (cnt % 2 == 0)
                   mat= Resources.Load("cube1") as Material;
               else
                   mat = Resources.Load("cube2") as Material;
               cnt++;
               cube.GetComponent<Renderer>().material = mat;
               cube.tag = "cube";*/


            GameObject cube = Instantiate(Prefab) as GameObject;
            cube.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 10;
            /*Material mat = null;
            if (cnt % 2 == 0)
                mat = Resources.Load("cube1") as Material;
            else
                mat = Resources.Load("cube2") as Material;
            cnt++;
            cube.GetComponent<Renderer>().material = mat;*/
            cube.GetComponent<Renderer>().enabled = true;
            cube.tag = "cube";
        } 
    }


}
