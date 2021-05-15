using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Show360Images : MonoBehaviour
{
    //this is to change the scene from main to library
  public void showLibraryScene(){
	SceneManager.LoadScene("LibraryScene");
  }

   //this is to change the scene from main to auditorium
  public void showAuditoriumScene(){
	SceneManager.LoadScene("AuditoriumScene");
  }

  //this is to change the scene from main to Canteen
  public void showCanteenScene(){
	SceneManager.LoadScene("CanteenScene");
  }

  //this is to change the scene from main to Classroom
  public void showClassroomScene(){
	SceneManager.LoadScene("ClassroomScene");
  }

  //this is to change the scene from main to MBlockLobby
  public void showMBlockLobbyScene(){
	SceneManager.LoadScene("MBlockLobbyScene");
  }

  //this is to change the scene from main to VITInfrastructure
  public void showVITInfrastructureScene(){
	SceneManager.LoadScene("VITInfrastructureScene");
  }
  //this is to change the scene from main to Ground
  public void showGroundScene(){
	SceneManager.LoadScene("GroundScene");
  }
  //this is to change the scene from any 360 image view to main scene
 public void showMainScene(){
	SceneManager.LoadScene("VITScene");
 }
 //this is to change the scene from any particular model scene to main scene
 public void goToMainScene(){
	SceneManager.LoadScene("MainScene");
 }
}
