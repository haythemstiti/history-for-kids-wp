using UnityEngine;
using System.Collections;

public class Navigate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void goHelp()
    {
        Application.LoadLevel(1);
    }

    public void goGame()
    {
        Application.LoadLevel(3);
    }

    public void goAbout()
    {
        Application.LoadLevel(2);
    }
    public void goBack()
    {
        Application.LoadLevel(0);
    }
}
