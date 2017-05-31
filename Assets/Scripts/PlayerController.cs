using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody))]
public class PlayerController : MonoBehaviour {

    Rigidbody rigidBody;
    Vector3 velocity;

	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	public void Move (Vector3 velocity) {
        this.velocity = velocity;
	}

    public void FixedUpdate() {
        rigidBody.MovePosition(rigidBody.position + velocity * Time.fixedDeltaTime);
    }

    public void LookAt(Vector3 point) {
        Vector3 heightCorrectedPoint = new Vector3(point.x, transform.position.y, point.z);
        transform.LookAt(heightCorrectedPoint);
    }
}
