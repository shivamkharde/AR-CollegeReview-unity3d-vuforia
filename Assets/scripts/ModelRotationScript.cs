using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelRotationScript : MonoBehaviour
{
   //getting game object/3d model
public GameObject objectRotation;

  //setting rotation speed
public float rotationSpeed = 5.0f;

  //original rotation val
public Quaternion originalRotationVal;

  //rotation reset speed;
public float rotationResetSpeed = 1.0f;

  //setting rotate status to false
bool rotateStatus = false;

    //this function is to rotate the 3d model
    public void rotateBtn()
    {
       if(rotateStatus == false){
	rotateStatus = true;
       }else{
	rotateStatus = false;
       }
        
    }
    
    void start(){
    	originalRotationVal = transform.rotation;
    }

    void Update(){
	if(rotateStatus == true){
		objectRotation.transform.Rotate(new Vector3(0f,1f,0f) , rotationSpeed * Time.deltaTime);
	}else{
		objectRotation.transform.rotation = Quaternion.Slerp(transform.rotation,originalRotationVal, Time.time * rotationResetSpeed);
	}
    }
}
