using UnityEngine;

public class rotatewheel : MonoBehaviour
{
    //public float rotate_speed = 50.0f; //expose it in the inspector but puting it private. 
    [SerializeField] Vector3 rotationSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);//the transform component of that object. Time.deltatime --> to normalize it! Use it when we use values inside update.  
    }
}
