using UnityEngine;

public class ScaleObject : MonoBehaviour
{

    [SerializeField] private float scaleSpeed = 1.5f; // Speed of rotation in degrees per second  

    private GameObject objectToScale;

    public void ScaleObjectUp()
    {
        CheckAndAssignObjectToScales();
        objectToScale.transform.localScale *= scaleSpeed;
        Debug.Log("Scale object: " + objectToScale.name + " up.");
    }

    public void ScaleObjectDown()
    {
        CheckAndAssignObjectToScales();
        objectToScale.transform.localScale /= scaleSpeed;
        Debug.Log("Scale object: " + objectToScale.name + " down.");
    }
    
    private void CheckAndAssignObjectToScales()
    {
        if (!objectToScale)
        {
            objectToScale = GameObject.FindWithTag("TrackedObject");
        }
    }
}
