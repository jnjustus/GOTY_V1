using UnityEngine;
using System.Collections;

public class Throw : MonoBehaviour {
    public float thrust;
    public Rigidbody rb;
    public Camera cam;
    public float throwTime;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        cam = GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update () {

        rb.AddForce(transform.forward * thrust);
	}
}
