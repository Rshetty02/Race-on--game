using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionTracking : MonoBehaviour
{

    public GameObject PlayerCar;

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
    
    public GameObject Score;

    public float zp;
    public float AI1;
    public float AI2;
    public float AI3;
    public float AI4;
    public float AI5;
    public float AI6;
    public float AI7;
    public float AI8;
    public float AI9;
    public float AI10;
    public float AI11;
    
    
    public float[] arr = new float[12];

    public int pos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   zp = PlayerCar.transform.position.z;
        AI1 =  AICar1.transform.position.z;
        AI2 =  AICar2.transform.position.z;
        AI3 =  AICar3.transform.position.z;
        AI4 =  AICar4.transform.position.z;
        AI5 =  AICar5.transform.position.z;
        AI6 =  AICar6.transform.position.z;
        AI7 =  AICar7.transform.position.z;
        AI8 =  AICar8.transform.position.z;
        AI9 =  AICar9.transform.position.z;
        AI10 =  AICar10.transform.position.z;
        AI11 =  AICar11.transform.position.z;
        

        arr[0] = zp;
        arr[1] = AI1;
        arr[2] = AI2;
        arr[3] = AI3;
        arr[4] = AI4;
        arr[5] = AI5;
        arr[6] = AI6;
        arr[7] = AI7;
        arr[8] = AI8;
        arr[9] = AI9;
        arr[10] = AI10;
        arr[11] = AI11;
        
        
        

        for (int i = 0; i <= arr.Length - 1; i++)  
        {  
            for (int j = 0; j <= arr.Length - 2; j++)  
            {  
                if (arr[j] > arr[j + 1])  
                {  
                    float temp = arr[j];  
                    arr[j] = arr[j + 1];  
                    arr[j + 1] = temp;  
                }  
            }  
        }

        for (int i=0; i<=arr.Length -1;i++ ){
            if(arr[i] == zp){

                pos = i +1;

            }
        }
        Score.GetComponent<Text>().text = "" + pos;

        }

        
          



        

        
    
}
