using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapCubes : MonoBehaviour {
    List<GameObject> gos;

    // Use this for initialization
    void Start () {
        gos = new List<GameObject>(GameObject.FindGameObjectsWithTag("cube"));
        gos.Remove(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        GameObject go = GetClosestCube(gos);
        float distance = Vector3.Distance(go.transform.position, transform.position);
        if (distance < 1.3f)
            fixYAxisAndRotation(go);
        gos = new List<GameObject>(GameObject.FindGameObjectsWithTag("cube"));
        gos.Remove(gameObject);
    }

    void fixYAxisAndRotation(GameObject closestGameObject)
    {
        gameObject.transform.SetPositionAndRotation(
        new Vector3(gameObject.transform.position.x, closestGameObject.transform.position.y, gameObject.transform.position.z),
        closestGameObject.transform.rotation);

        print("fixed y-axis");
    }
    
    GameObject GetClosestCube(List<GameObject> cubes)
    {

        GameObject cMin = null;
        float minDist = Mathf.Infinity;
        Vector3 currentPos = transform.position;
        foreach (GameObject c in cubes)
        {
            float dist = Vector3.Distance(c.transform.position, currentPos);
            if (dist < minDist)
            {
                cMin = c;
                minDist = dist;
            }
        }
        return cMin;
    }
}
