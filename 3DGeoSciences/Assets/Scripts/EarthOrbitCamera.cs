using UnityEngine;
using System.Collections;

public class EarthOrbitCamera : MonoBehaviour
{
    public float distance = 1.2f;
    public float _Sensitivity;

    float _currentRotationRight = 0f;
    float _currentRotationUp = 0f;
    
    void Start ()
    {
        Rotate(_currentRotationRight, _currentRotationUp);
    }


	void Update ()
    {
        if (Input.GetMouseButton(0))
        {
            _currentRotationRight += Input.GetAxis("Mouse Y") * _Sensitivity;
            _currentRotationUp += Input.GetAxis("Mouse X") * _Sensitivity;
            Rotate( _currentRotationRight, _currentRotationUp);

        }
        	
	}

    void Rotate(float right, float up)
    {
        Quaternion rotation = Quaternion.Euler(-right, up, 0f);
        transform.rotation = rotation;
        Vector3 percheASelfie = new Vector3(0f, 0f, -distance);
        transform.position = rotation * percheASelfie;
    }
}
