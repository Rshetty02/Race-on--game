using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Change : MonoBehaviour
{
    public GameObject Third_person_cam;
    public GameObject First_person_cam;
    public int Cam_mode;



    // Update is called once per frame
    void Update()
    {
        if(Cam_mode==1){
            Cam_mode = 0;
        }
        else{
            Cam_mode += 1;
        }

    }

    IEnumerator ModeChange(){
        yield return new WaitForSeconds(0.01f);
        if(Cam_mode==0){
            Third_person_cam.SetActive(true);
            First_person_cam.SetActive(false);
        }
        if(Cam_mode == 1){
            Third_person_cam.SetActive(false);
            First_person_cam.SetActive(true);
            

        }


    }
}
