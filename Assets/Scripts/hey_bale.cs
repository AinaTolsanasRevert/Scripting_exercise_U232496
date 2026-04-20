using UnityEngine;

public class hey_bale : MonoBehaviour
{
    [SerializeField] float movementSpeed = 30.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(300,50,0)*Time.deltaTime);
        //transform.Translate(new Vector3(0, 0, movementSpeed * Time.deltaTime),Space.World);
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime, Space.World);
    }
}
