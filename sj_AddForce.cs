/************************************************************
note
	Rigidbodyの設定で、 Use Gravityのcheckを外すこと.
************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************************
************************************************************/
public class sj_AddForce : MonoBehaviour
{
	/****************************************
	****************************************/
	Rigidbody rb;
	Vector3 target_velocity;
	string str_message;

	/****************************************
	****************************************/
	/******************************
	******************************/
    void Start()
    {
        rb = GetComponent<Rigidbody>();
		target_velocity = new Vector3(10f, 0f, 0f);
    }

	/******************************
	******************************/
    void FixedUpdate()
    {
        rb.AddForce(target_velocity*rb.mass*rb.drag/(1f-rb.drag * Time.fixedDeltaTime));
		str_message = string.Format("{0:0.000}", rb.velocity.magnitude);
		// Debug.Log(rb.velocity.magnitude);
    }
	
	/******************************
	******************************/
	void OnGUI()
	{
		// GUI.color = Color.white;
		GUI.color = Color.red;
		
		/********************
		********************/
		GUI.Label(new Rect(15, 20, 500, 30), str_message);
	}
}
