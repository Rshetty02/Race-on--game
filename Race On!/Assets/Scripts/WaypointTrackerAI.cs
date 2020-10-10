using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointTrackerAI : MonoBehaviour
{
    public GameObject TheMarker;
    public GameObject mark01;
    public GameObject mark02;
    public GameObject mark03;
    public GameObject mark04;
    public GameObject mark05;
    public GameObject mark06;
    public GameObject mark07;

    public int MarkTracker;

    // Update is called once per frame
    void Update()
    {
        if(MarkTracker==0){
            TheMarker.transform.position = mark01.transform.position;
        }

        if(MarkTracker==1){
            TheMarker.transform.position = mark02.transform.position;
        }

        if(MarkTracker==2){
            TheMarker.transform.position = mark03.transform.position;
        }

        if(MarkTracker==3){
            TheMarker.transform.position = mark04.transform.position;
        }

        if(MarkTracker==4){
            TheMarker.transform.position = mark05.transform.position;
        }

        if(MarkTracker==5){
            TheMarker.transform.position = mark06.transform.position;
        }

        if(MarkTracker==6){
            TheMarker.transform.position = mark06.transform.position;
        }

    }

    IEnumerator OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="AICAR1"){
            this.GetComponent<BoxCollider>().enabled= false;
            MarkTracker +=1;
            if(MarkTracker>=6){
                MarkTracker = 0;
            }
        }
            yield return new WaitForSeconds (0.2f);
            this.GetComponent<BoxCollider>().enabled = true;

        
    }
}
