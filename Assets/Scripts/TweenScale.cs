using UnityEngine;

public class TweenScale : MonoBehaviour
{
    public float targetScale = 0.5f; // 1
    public float timeToReachTarget = 1.5f; // 2
    private float startScale;  // 3
    private float percentScaled; // 4
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startScale = transform.localScale.x;
        percentScaled = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (percentScaled < 1f) // 1
        {
            percentScaled += Time.deltaTime / timeToReachTarget; // 2
            percentScaled = Mathf.Clamp01(percentScaled);
            float scale = Mathf.Lerp(startScale, targetScale, percentScaled); // 3
            transform.localScale = new Vector3(scale, scale, scale); // 4
        }
    }
}
