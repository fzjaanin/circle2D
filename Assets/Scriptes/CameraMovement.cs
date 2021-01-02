using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
   public Transform circle;
   
    void Update()
    {
    	Vector3 circlePos = new Vector3(circle.position.x, circle.position.y, -1);
       transform.position = Vector3.Lerp (transform.position, circlePos, 2f * Time.deltaTime);
    }
}
