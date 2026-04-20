using UnityEngine;

public class Machine : MonoBehaviour
{
    [SerializeField] Transform spamPoint;
    [SerializeField] GameObject hayBalePrefab;
    [SerializeField] float shootInterval = 3.0f;
    [SerializeField] float shootTimer;

    [SerializeField] float movementSpeed = 20.0f;
    [SerializeField] float xLimitRight = 20.0f;
    [SerializeField] float yLimitLeft = -20.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0 && transform.position.x < xLimitRight)
        {
            transform.Translate(new Vector3(movementSpeed * Time.deltaTime,0,0));
        }else if(Input.GetAxisRaw("Horizontal") < 0 && transform.position.x > yLimitLeft)
        {
            transform.Translate(new Vector3(movementSpeed * -1 * Time.deltaTime,0,0)); 
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(hayBalePrefab, spamPoint.position, spamPoint.rotation);
            SoundManager.Instance.PlayShootClip();

        }
    }
}
