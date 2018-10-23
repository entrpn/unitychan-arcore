using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanControl : MonoBehaviour {

    public float animSpeed = 1.5f;

    public float forwardSpeed = .2f;

    public float backwardSpeed = 2.0f;

    public float rotateSpeed = 2.0f;

    public float jumpPower = 3.0f;

    //public Joystick joystick;

    private Rigidbody rb;

    private Animator animator;

    private Vector3 firstTouchPoint = new Vector3(0, 0, 0);

    private Transform startMarker;
    private Vector3 endMarker;
    private float journeyLen = 0;
    private float startTime = 0;

    // Use this for initialization
    void Start () {
        Debug.Log("UnityChanControl start()");
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
	}

    public void setRunningAnimation() {
    }

    public void setJumpAnimation() {
        setAnimation("Jump");
    }

    private void setAnimation(string AnimationString) {
        if (!animator.IsInTransition(0)) {
            animator.SetBool(AnimationString, true);
        }
    }
	
    void Update()
    {
        if (journeyLen > 0) {
            float distCovered = (Time.time - startTime) * forwardSpeed;
            float fracJourney = distCovered / journeyLen;
            transform.position = Vector3.Lerp(startMarker.position, endMarker, fracJourney);
        }
    }


    public void MoveUnityChan(Vector3 endPos)
    {
        startMarker = this.transform;
        endMarker = endPos;
        startTime = Time.time;
        journeyLen = Vector3.Distance(startMarker.position, endMarker);


        //rb.AddForce(direction * forwardSpeed * Time.deltaTime);
        //transform.Translate(direction * forwardSpeed * Time.deltaTime);
    }
}
