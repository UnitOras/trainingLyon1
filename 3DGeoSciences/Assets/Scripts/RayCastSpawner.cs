using UnityEngine;
using System.Collections;

public class RayCastSpawner : MonoBehaviour
{
    public GameObject prefab;
    private float lasttimeMouseButtonDown;
	
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lasttimeMouseButtonDown = Time.time;
        }

        if (Input.GetMouseButtonUp(0) && Time.time -lasttimeMouseButtonDown < 0.1f)
        {
            SpawnOnHit();
        }
        
    }

    void SpawnOnHit()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) == true)
        {
            GameObject go = (GameObject) Instantiate(prefab, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
        }
	}
}
