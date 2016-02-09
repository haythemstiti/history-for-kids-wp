using UnityEngine;
using System.Collections;

public class SelectShow : MonoBehaviour {

    public GameObject selectLevel;
    private GameObject select;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag=="Player")
        {
            Debug.Log("Level collision");
           select = Instantiate(selectLevel) as GameObject;
        }
    }

    void OnTriggerExit(Collider col)
    {
        Destroy(select);
    }
}
