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

    public GameObject mark08;

    public GameObject mark09;

    public GameObject mark10;
    public GameObject mark11;
    public GameObject mark12;
    public GameObject mark13;

    public GameObject mark14;

    public GameObject mark15;

    public GameObject mark16;
    public GameObject mark17;
    public GameObject mark18;
    public GameObject mark19;
    public GameObject mark20;
    public GameObject mark21;
    public GameObject mark22;
    public GameObject mark23;
    public GameObject mark24;
    public GameObject mark25;
    public GameObject mark26;
    public GameObject mark27;
    public GameObject mark28;
    public GameObject mark29;
    public GameObject mark30;
    public GameObject mark31;
    public GameObject mark32;
    public GameObject mark33;
    public GameObject mark34;
    public GameObject mark35;
    public GameObject mark36;
    public GameObject mark37;
    public GameObject mark38;
    public GameObject mark39;
    public GameObject mark40;
    public GameObject mark41;
    public GameObject mark42;
    public GameObject mark43;
    public GameObject mark44;

    public int MarkTracker;

    // Update is called once per frame
    void FixedUpdate()
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
            TheMarker.transform.position = mark07.transform.position;
        }
        if(MarkTracker==7){
            TheMarker.transform.position = mark08.transform.position;
        }
        if(MarkTracker==8){
            TheMarker.transform.position = mark09.transform.position;
        }
        if(MarkTracker==9){
            TheMarker.transform.position = mark10.transform.position;
        }
        if(MarkTracker==10){
            TheMarker.transform.position = mark11.transform.position;
        }
        if(MarkTracker==11){
            TheMarker.transform.position = mark12.transform.position;
        }
        if(MarkTracker==12){
            TheMarker.transform.position = mark13.transform.position;
        }
        if(MarkTracker==13){
            TheMarker.transform.position = mark14.transform.position;
        }
        if(MarkTracker==14){
            TheMarker.transform.position = mark15.transform.position;
        }
        if(MarkTracker==15){
            TheMarker.transform.position = mark16.transform.position;
        }
        if(MarkTracker==16){
            TheMarker.transform.position = mark17.transform.position;
        }
        if(MarkTracker==17){
            TheMarker.transform.position = mark18.transform.position;
        }
        if(MarkTracker==18){
            TheMarker.transform.position = mark19.transform.position;
        }
        if(MarkTracker==19){
            TheMarker.transform.position = mark20.transform.position;
        }
        if(MarkTracker==20){
            TheMarker.transform.position = mark21.transform.position;
        }
        if(MarkTracker==21){
            TheMarker.transform.position = mark22.transform.position;
        }
        if(MarkTracker==22){
            TheMarker.transform.position = mark23.transform.position;
        }
        if(MarkTracker==23){
            TheMarker.transform.position = mark24.transform.position;
        }
        if(MarkTracker==24){
            TheMarker.transform.position = mark25.transform.position;
        }
        if(MarkTracker==25){
            TheMarker.transform.position = mark26.transform.position;
        }
        if(MarkTracker==26){
            TheMarker.transform.position = mark27.transform.position;
        }
        if(MarkTracker==27){
            TheMarker.transform.position = mark28.transform.position;
        }
        if(MarkTracker==28){
            TheMarker.transform.position = mark29.transform.position;
        }
        if(MarkTracker==29){
            TheMarker.transform.position = mark30.transform.position;
        }
        if(MarkTracker==30){
            TheMarker.transform.position = mark31.transform.position;
        }
        if(MarkTracker==31){
            TheMarker.transform.position = mark32.transform.position;
        }
        if(MarkTracker==32){
            TheMarker.transform.position = mark33.transform.position;
        }
        if(MarkTracker==33){
            TheMarker.transform.position = mark34.transform.position;
        }
        if(MarkTracker==34){
            TheMarker.transform.position = mark35.transform.position;
        }
        if(MarkTracker==35){
            TheMarker.transform.position = mark36.transform.position;
        }
        if(MarkTracker==36){
            TheMarker.transform.position = mark37.transform.position;
        }
        if(MarkTracker==37){
            TheMarker.transform.position = mark38.transform.position;
        }
        if(MarkTracker==38){
            TheMarker.transform.position = mark39.transform.position;
        }
        if(MarkTracker==39){
            TheMarker.transform.position = mark40.transform.position;
        }
        if(MarkTracker==40){
            TheMarker.transform.position = mark41.transform.position;
        }
        if(MarkTracker==41){
            TheMarker.transform.position = mark42.transform.position;
        }
        if(MarkTracker==42){
            TheMarker.transform.position = mark43.transform.position;
        }
        if(MarkTracker==43){
            TheMarker.transform.position = mark44.transform.position;
        }

    }

    IEnumerator OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="AICAR1"){
            this.GetComponent<BoxCollider>().enabled= false;
            MarkTracker +=1;
            if(MarkTracker>=43){
                MarkTracker = 0;
            }
        }
            yield return new WaitForSeconds (0.2f);
            this.GetComponent<BoxCollider>().enabled = true;

        
    }
}
