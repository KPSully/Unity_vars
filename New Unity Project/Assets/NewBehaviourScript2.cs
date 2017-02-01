using UnityEngine;
using System.Collections;
// this is a comment
public class NewBehaviourScript2 : MonoBehaviour {
    public float speed = 1.0f;
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * speed);
	}
}
