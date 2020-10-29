using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkyBox : MonoBehaviour
{

    public Material skyboxday;
    public Material skyboxnight;
    public Material skyboxovercast;
    public Material skyboxevening;

    public int track;

    // Start is called before the first frame update
    void Start()
    {
        track = start_game_scene.track;

        if(track == 4){
        RenderSettings.skybox = skyboxevening;
        }
        else if(track == 2){
            RenderSettings.skybox = skyboxnight;;
        }
        else if(track == 3){
            RenderSettings.skybox = skyboxovercast;
        }
        else{
            RenderSettings.skybox  = skyboxday;
        }
    }

    

    
}
