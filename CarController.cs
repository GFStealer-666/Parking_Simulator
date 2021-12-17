using UnityEngine;

public class CarController : MonoBehaviour
{
    private float horizontalInput, verticalInput, steerAngle;
    private bool handBrake;

    public float maxSteeringAngle = 30f, motorForce = 50f, brakeForce = 0f, speedboost = 0;
    public WheelCollider frontLeftWheelCollider, frontRightWheelCollider, rearLeftWheelCollider, rearRightWheelCollider;
    public Transform frontLeftWheelTransform, frontRightWheelTransform, rearLeftWheelTransform, rearRightWheelTransform;
    public GameObject Car;

    private void FixedUpdate()
    {
        InputfromKeyboard();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
        Nitro();

        //  Debug.Log(Car.GetComponent<Rigidbody>().velocity);
    }

    public void Nitro()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            frontLeftWheelCollider.motorTorque = 0.25f * motorForce * 100;
            frontRightWheelCollider.motorTorque = 0.25f * motorForce * 100;

            //   Car.GetComponent<Rigidbody>().velocity = new Vector3(x += 0.05f, Car.GetComponent<Rigidbody>().velocity.y, Car.GetComponent<Rigidbody>().velocity.z);
            Car.GetComponent<Rigidbody>().AddForce(transform.forward * 0.1f, ForceMode.VelocityChange);
        }
    }

    private void InputfromKeyboard()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        handBrake = Input.GetKey(KeyCode.Space);
    }

    private void HandleSteering()
    {
        steerAngle = maxSteeringAngle * horizontalInput;
        frontLeftWheelCollider.steerAngle = steerAngle;
        frontRightWheelCollider.steerAngle = steerAngle;
    }

    private void HandleMotor()
    {
        frontLeftWheelCollider.motorTorque = verticalInput * motorForce;
        frontRightWheelCollider.motorTorque = verticalInput * motorForce;

        if (handBrake == true)
        {
            brakeForce = 20000f;
        }
        else
        {
            brakeForce = 0f;
        }

        frontLeftWheelCollider.brakeTorque = brakeForce;
        frontRightWheelCollider.brakeTorque = brakeForce;
        rearLeftWheelCollider.brakeTorque = brakeForce;
        rearRightWheelCollider.brakeTorque = brakeForce;
    }

    private void UpdateWheels()
    {
        UpdateWheelPos(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateWheelPos(frontRightWheelCollider, frontRightWheelTransform);
        UpdateWheelPos(rearLeftWheelCollider, rearLeftWheelTransform);
        UpdateWheelPos(rearRightWheelCollider, rearRightWheelTransform);
    }

    private void UpdateWheelPos(WheelCollider wheelCollider, Transform trans)
    {
        Vector3 position;
        Quaternion rotate;
        wheelCollider.GetWorldPose(out position, out rotate);
        trans.rotation = rotate;
        trans.position = position;

        //   Debug.Log(position + "position");
        //   Debug.Log(rotate + "rotate");
    }
}