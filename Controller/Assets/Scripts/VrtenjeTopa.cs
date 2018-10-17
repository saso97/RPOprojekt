using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrtenjeTopa : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
       
            var direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            var angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.back);
	}
}
