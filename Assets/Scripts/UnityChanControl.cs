using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanControl : MonoBehaviour {

    public float animSpeed = 1.5f;

    public float forwardSpeed = 7.0f;

    public float backwardSpeed = 2.0f;

    public float rotateSpeed = 2.0f;

    public float jumpPower = 3.0f;

    //public Joystick joystick;

    private Rigidbody rb;

    private Vector3 firstTouchPoint = new Vector3(0, 0, 0);

    // Use this for initialization
    void Start () {
        Debug.Log("UnityChanControl start()");
        rb = GetComponent<Rigidbody>();
	}
	
    private void Update()
    {
        //Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical);

        //if (moveVector != Vector3.zero)
        //{
        //    transform.rotation = Quaternion.LookRotation(moveVector);
        //    transform.Translate(moveVector * forwardSpeed * Time.deltaTime, Space.World);
        //}
        //foreach (Touch touch in Input.touches)
        //{
        //    if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
        //    {
        //        doOnTouch(touch);
        //    }
        //    else
        //    {
        //        firstTouchPoint = new Vector3(0f, 0f, 0f);
        //    }
        //}
    }

    //private void doOnTouch(Touch touch)
    //{
    //    Debug.Log("TESTEST, UnityChanControl doOnTouch()");
    //    // move unitychan
    //    if (firstTouchPoint.x <= 0f && firstTouchPoint.y <= 0f && firstTouchPoint.z <= 0f)
    //    {
    //        Debug.Log("TESTEST, firstTouchPoint, x: " + touch.position.x + ", y: " + touch.position.y);
    //        firstTouchPoint = new Vector3(touch.position.x, 0, touch.position.y);
    //    }
    //    else
    //    {
    //        // calculate difference and move player
    //        Vector3 currentTouchPoint = new Vector3(touch.position.x, 0, touch.position.y);
    //        Vector3 offset = currentTouchPoint - firstTouchPoint;
    //        Debug.Log("TESTEST, calculating offset " + offset);
    //        moveUnityChan(Vector3.ClampMagnitude(offset, 1.0f));
    //    }
    //}

    public void MoveUnityChan(Vector3 direction)
    {
        //rb.AddForce(direction);
        transform.Translate(direction * forwardSpeed * Time.deltaTime);
    }
}
