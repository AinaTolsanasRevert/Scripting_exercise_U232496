using UnityEngine;

public class Sheep : MonoBehaviour
{
    //public float runSpeed;
    //public float gotHayDestroyDelay;
    private bool hitByHay;

    [SerializeField] float runSpeed = 10.0f;
    [SerializeField] float gotHayDestroyDelay = 0.5f;

    public float dropDestroyDelay;
    private Collider myCollider;
    private Rigidbody myRigidbody;

    private SheepSpawner sheepSpawner;

    public float heartOffset; // 1
    public GameObject heartPrefab; // 2


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myCollider = GetComponent<Collider>();
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*runSpeed*Time.deltaTime);
    }
    private void HitByHay()
    {
        sheepSpawner.RemoveSheepFromList(gameObject);
        hitByHay = true;
        runSpeed = 0;
        Destroy(gameObject, gotHayDestroyDelay);

        Instantiate(heartPrefab, transform.position + new Vector3(0, heartOffset, 0), Quaternion.identity);
        TweenScale tweenScale = gameObject.AddComponent<TweenScale>(); ; // 1
        tweenScale.targetScale = 0; // 2
        tweenScale.timeToReachTarget = gotHayDestroyDelay; // 3
        SoundManager.Instance.PlaySheepHitClip();

        GameStateManager.Instance.SavedSheep();



    }
    private void Drop()
    {
        GameStateManager.Instance.DroppedSheep();

        sheepSpawner.RemoveSheepFromList(gameObject);
        myRigidbody.isKinematic = false;
        myCollider.isTrigger = false;
        myRigidbody.useGravity = true;
        Destroy(gameObject, dropDestroyDelay);

        SoundManager.Instance.PlaySheepDroppedClip();

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Hay") && !hitByHay)
        {
            Destroy(other.gameObject);
            HitByHay();
        }
        else if (other.CompareTag("DropSheep"))
        {
            Drop();
        }
    }
    
    public void SetSpawner(SheepSpawner spawner)
    {
        sheepSpawner = spawner;
    }
}
