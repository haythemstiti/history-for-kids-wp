using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour
{
    private bool isMovingRight = false;
    private bool isMovingLeft = false;
    private Animator anim;
    private GameObject camera;
    private Camera2DFollow cf;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        camera = GameObject.Find("Main Camera");
        cf = camera.GetComponent<Camera2DFollow>();
    }

    // Update is called once per frame
    void Update()
    {


        if (isMovingRight)
        {
            if (transform.position.x < 7.1f)
            {
                gameObject.transform.Translate(Vector2.right * Time.deltaTime);
            }
        }
        else if (isMovingLeft)
        {
            if (transform.position.x > -7.13f)
            {
                gameObject.transform.Translate(-Vector2.right * Time.deltaTime);
            }

        }

    }

    public void pressHold()
    {
        cf.isMovingRight = true;
        isMovingRight = true;
        anim.SetFloat("speed", 0.2f);
    }

    public void pressReleased()
    {
        cf.isMovingRight = false;
        isMovingRight = false;
        anim.SetFloat("speed", 0f);
    }

    public void pressHoldLeft()
    {
        cf.isMovingLeft = true;
        isMovingLeft = true;
        anim.SetFloat("speedLeft", 0.2f);
    }

    public void pressReleasedLeft()
    {
        cf.isMovingLeft = false;
        isMovingLeft = false;
        anim.SetFloat("speedLeft", 0f);
    }

    


}
