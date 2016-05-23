using UnityEngine;
using System.Collections;

public class MoveController : MonoBehaviour {
    private int speed = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 direction = transform.rotation * Vector3.forward;

        if (direction.y <= .2) {
            speed = 5;
            Vector3 motion = new Vector3(direction.x, 0, direction.z);

            motion.Normalize();
            transform.position += motion * speed * Time.deltaTime;
        } else {
            speed = 0;
        }
	}
}
