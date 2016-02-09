using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ManageHelpMenu : MonoBehaviour {

	private int currentImage = 1;
	private Image img;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    private Button btnForward;
    private Button btnBack;
	// Use this for initialization
	void Start () {
        img = GameObject.Find("HelpImage").GetComponent<Image>();
        btnBack = GameObject.Find("btnBack").GetComponent<Button>();
        btnForward = GameObject.Find("btnForward").GetComponent<Button>();
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void changeHelpImage(){
        Debug.Log("button clicked");
		if (currentImage == 1) {
            img.sprite = sprite2;
            btnBack.enabled = true;
            currentImage++;
		}
        else if (currentImage == 2)
        {
            img.sprite = sprite3;
            btnForward.enabled = false;
            currentImage++;
        }
	}
    public void changeHelpImageBack()
    {
        Debug.Log("button clicked");
        if (currentImage == 3)
        {
            img.sprite = sprite2;
            btnForward.enabled = true;
            currentImage--;
        }
        else if (currentImage == 2)
        {
            img.sprite = sprite1;
            btnBack.enabled = false;
            currentImage--;
        }
    }

    public void goBack()
    {
        Application.LoadLevel(0);
    }

   
}
