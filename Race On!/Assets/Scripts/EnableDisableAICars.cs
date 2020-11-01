using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableAICars : MonoBehaviour
{
    public GameObject AICar1;
    public GameObject AICar2;
    public GameObject AICar3;
    public GameObject AICar4;
    public GameObject AICar5;
    public GameObject AICar6;
    public GameObject AICar7;
    public GameObject AICar8;
    public GameObject AICar9;
    public GameObject AICar10;
    public GameObject AICar11;
    
        // Start is called before the first frame update
    void Start()
    {
        if(NoofAICars.NoOfAICarsvar ==3){
            AICar1.SetActive(true);
            AICar2.SetActive(true);
            AICar3.SetActive(true);
            AICar4.SetActive(false);
            AICar5.SetActive(false);
            AICar6.SetActive(false);
            AICar7.SetActive(false);
            AICar8.SetActive(false);
            AICar9.SetActive(false);
            AICar10.SetActive(false);
            AICar11.SetActive(false);
        }
        else if(NoofAICars.NoOfAICarsvar ==7){
            AICar1.SetActive(true);
            AICar2.SetActive(true);
            AICar3.SetActive(true);
            AICar4.SetActive(true);
            AICar5.SetActive(true);
            AICar6.SetActive(true);
            AICar7.SetActive(true);
            AICar8.SetActive(false);
            AICar9.SetActive(false);
            AICar10.SetActive(false);
            AICar11.SetActive(false);
        }
        else if(NoofAICars.NoOfAICarsvar ==9){
            AICar1.SetActive(true);
            AICar2.SetActive(true);
            AICar3.SetActive(true);
            AICar4.SetActive(true);
            AICar5.SetActive(true);
            AICar6.SetActive(true);
            AICar7.SetActive(true);
            AICar8.SetActive(true);
            AICar9.SetActive(true);
            AICar10.SetActive(false);
            AICar11.SetActive(false);
        }
        else if(NoofAICars.NoOfAICarsvar ==11){
            AICar1.SetActive(true);
            AICar2.SetActive(true);
            AICar3.SetActive(true);
            AICar4.SetActive(true);
            AICar5.SetActive(true);
            AICar6.SetActive(true);
            AICar7.SetActive(true);
            AICar8.SetActive(true);
            AICar9.SetActive(true);
            AICar10.SetActive(true);
            AICar11.SetActive(true);
        }

        else if(NoofAICars.NoOfAICarsvar ==1){
            AICar1.SetActive(true);
            AICar2.SetActive(false);
            AICar3.SetActive(false);
            AICar4.SetActive(false);
            AICar5.SetActive(false);
            AICar6.SetActive(false);
            AICar7.SetActive(false);
            AICar8.SetActive(false);
            AICar9.SetActive(false);
            AICar10.SetActive(false);
            AICar11.SetActive(false);
        }
        else{
            AICar1.SetActive(true);
            AICar2.SetActive(false);
            AICar3.SetActive(false);
            AICar4.SetActive(false);
            AICar5.SetActive(false);
            AICar6.SetActive(false);
            AICar7.SetActive(false);
            AICar8.SetActive(false);
            AICar9.SetActive(false);
            AICar10.SetActive(false);
            AICar11.SetActive(false);
        }
    
    }

   
}
