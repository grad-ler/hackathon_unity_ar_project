using UnityEngine;

public class RotateObject : MonoBehaviour
{

    [SerializeField] private float rotationSpeed = 10f; // Speed of rotation in degrees per second  
    [SerializeField] private Vector3 rotationAxis = new Vector3(0, 1, 0); // Axis of rotation (Y-axis by default)

    private GameObject objectToRotate;

    public void RotateObjectLeft()
    {
        // Rotate the object around the specified axis
        CheckAndAssignObjectToRotate();
        objectToRotate.transform.Rotate(rotationAxis * (-rotationSpeed), Space.World);
        Debug.Log("Rotate object: " + objectToRotate.name + " left. Rotation: " +  objectToRotate.transform.rotation.eulerAngles.ToString() );
    }

    public void RotateObjectRight()
    {
        // Rotate the object around the specified axis in the opposite direction
        CheckAndAssignObjectToRotate();
        objectToRotate.transform.Rotate(rotationAxis * rotationSpeed, Space.World);
        Debug.Log("Rotate object: " + objectToRotate.name + " right. Rotation: " +  objectToRotate.transform.rotation.eulerAngles.ToString());
    }
    
    private void CheckAndAssignObjectToRotate()
    {
        if (!objectToRotate)
        {
            objectToRotate = GameObject.FindWithTag("TrackedObject");
        }
    }
}
