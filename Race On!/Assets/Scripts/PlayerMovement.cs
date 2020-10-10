
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public Button handBrake;
    public Joystick joystick;
    public Transform wheelTopRightTransform;

    public Transform wheelTopLeftTransform;

    public Transform wheelBackRightTransform;

    public Transform wheelBackLeftTransform;
    
    public WheelCollider wheelTopRight;

    public WheelCollider wheelTopLeft;

    public  WheelCollider wheelBackRight;

    public WheelCollider wheelBackLeft;

    private Touch touch;

    private float speedModifier = 0.01f;

    public float forwardForce = 10000f;

    public float brakeForce = 999999f;

    public float stAngle = 30f;
    public Rigidbody rb;
    // Update is called once per frame

    public bool isHandBrakePressed;
    void Start() {

    isHandBrakePressed = false;
        
    }


    

    void FixedUpdate()
    {


        // handBrake.onClick.AddListener(handBrakePressed);
        
        
        //         wheelBackRight.brakeTorque = 0;
        //         wheelBackLeft.brakeTorque = 0;
        //         wheelTopLeft.brakeTorque = 0;
        //         wheelTopRight.brakeTorque = 0;

        
        
        /*

        
    if(Input.GetKey("w")){
    //while(Input.GetKey("w") && forwardForce<6000f){
    // wheelTopRight.AddForce(0,0,forwardForce * Time.deltaTime,ForceMode.VelocityChange);
    // wheelTopLeft.AddForce(0,0,forwardForce * Time.deltaTime,ForceMode.VelocityChange);
    // wheelBackRight.AddForce(0,0,forwardForce * Time.deltaTime,ForceMode.VelocityChange);
    // wheelBackLeft.AddForce(0,0,forwardForce * Time.deltaTime,ForceMode.VelocityChange);
    // 
    wheelTopLeft.motorTorque = forwardForce+100f;
    wheelTopRight.motorTorque = forwardForce+100f;
    wheelBackLeft.motorTorque = forwardForce+100f;
    wheelBackRight.motorTorque = forwardForce+100f;
    //rb.AddForce(0,0,forwardForce * Time.deltaTime,ForceMode.VelocityChange);
    }

    if(Input.GetKey("s")){
    //rb.AddForce(0,0,-forwardForce * Time.deltaTime,ForceMode.VelocityChange);
    wheelTopLeft.motorTorque = -forwardForce;
    wheelTopRight.motorTorque = -forwardForce;
    wheelBackLeft.motorTorque = -forwardForce;
    wheelBackRight.motorTorque = -forwardForce;
    }
    */
    /*
    float x = Input.acceleration.x;

    if(x<0){

        rb.AddForce(-sideForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        //rb.AddForce(sideForce * Time.deltaTime,0,0);


    }

    if(x>0){
        rb.AddForce(sideForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        //rb.AddForce(-sideForce * Time.deltaTime,0,0);

    }
    /* for accelero from phone



    /*
    if(Input.touchCount >0)
    {
        touch = Input.GetTouch(0);
        
        if(touch.phase == TouchPhase.Moved){
            transform.position = new Vector3(
                transform.position.x + (touch.deltaPosition.x*speedModifier),
                transform.position.y,
                transform.position.z

            );
        }

    }
*/
//float v = Input.GetAxis("Vertical") * forwardForce;
float v = joystick.Vertical * forwardForce;


wheelBackLeft.motorTorque =v;
wheelBackRight.motorTorque = v;
wheelTopLeft.motorTorque = v;
wheelTopRight.motorTorque = v; 

wheelTopRightTransform.Rotate(wheelTopRight.rpm/60 *360*Time.deltaTime,0,0);
wheelTopLeftTransform.Rotate(wheelTopLeft.rpm/60 *360*Time.deltaTime,0,0);
wheelBackLeftTransform.Rotate(wheelBackLeft.rpm/60 *360*Time.deltaTime,0,0);
wheelBackRightTransform.Rotate(wheelBackRight.rpm/60 *360*Time.deltaTime,0,0);




    
//float h = Input.GetAxis("Horizontal") * stAngle;
float h = joystick.Horizontal *stAngle;
wheelTopRight.steerAngle = h ;
wheelTopLeft.steerAngle = h;


/*
if(Input.GetKey(KeyCode.Space)){

    wheelBackRight.brakeTorque = brakeForce;
    wheelBackLeft.brakeTorque = brakeForce;
    wheelTopRight.brakeTorque = brakeForce;
    wheelTopLeft.brakeTorque = brakeForce;

}

//if(Input.GetKeyUp(KeyCode.Space)){

    wheelBackRight.brakeTorque = 0;
    wheelBackLeft.brakeTorque = 0;
    wheelTopLeft.brakeTorque = 0;
    wheelTopRight.brakeTorque = 0;
}
*/
  /*
    if(Input.GetKey("d")){
        //wheelTopRight.steerAngle = stAngle;
        wheelTopRight.steerAngle = stAngle + 10f;
        //wheelTopLeft.steerAngle = stAngle;
        wheelTopLeft.steerAngle = stAngle + 10f;
        //rb.AddForce(sideForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
    }

    if(Input.GetKey("a")){
        wheelTopRight.steerAngle = -stAngle - 10f;
        wheelTopLeft.steerAngle = -stAngle - 10f;
        //rb.AddForce(-sideForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
    }
    */


    

    
    

    if(rb.position.y < -1f){
        FindObjectOfType<GameManager>().Endgame();

    }


        
    }
/*
    public void handBrakePressed(){
    
    
    wheelBackRight.brakeTorque = brakeForce*10;
    wheelBackLeft.brakeTorque = brakeForce*10;
    wheelTopRight.brakeTorque = brakeForce*10;
    wheelTopLeft.brakeTorque = brakeForce*10;
    Debug.Log("Brake Pressed!");

    }*/



}
