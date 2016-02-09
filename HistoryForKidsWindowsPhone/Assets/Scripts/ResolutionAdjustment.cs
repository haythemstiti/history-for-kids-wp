using UnityEngine;
using System.Collections;

public class ResolutionAdjustment : MonoBehaviour {


    private float nativeWidth = 1920;
    private float nativeHeight = 1080;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI ()
 {
     //set up scaling
     float rx  = Screen.width / nativeWidth;
     float ry  = Screen.height / nativeHeight;
     GUI.matrix = Matrix4x4.TRS (new Vector3(0, 0, 0), Quaternion.identity,new  Vector3 (rx, ry, 1)); 
 
     //now create your GUI normally, as if you were in your native resolution
     //The GUI.matrix will scale everything automatically.

 
 }
}
