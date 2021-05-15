using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenModel : MonoBehaviour
{

    string button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

#if UNITY_EDITOR
	if(Input.GetMouseButtonDown(0))
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit Hit;
		if(Physics.Raycast(ray, out Hit)){
			if(Hit.transform.name == "VIT COLLEGE MODEL"){
Debug.Log("VIT");
		SceneManager.LoadScene("VITScene");
	}
if(Hit.transform.name == "vp"){
Debug.Log("vp");
		SceneManager.LoadScene("VPScene");
}
		}
	}
#elif UNITY_ANDROID
        if(Input.touchCount >0 && Input.touches[0].phase == TouchPhase.Began){
		Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
		RaycastHit Hit;
		if(Physics.Raycast(ray, out Hit)){
			if(Hit.transform.name == "VIT COLLEGE MODEL"){
		SceneManager.LoadScene("VITScene");
	}
if(Hit.transform.name == "vp"){
		SceneManager.LoadScene("VPScene");
}
		}
	}
#endif
    }
}
