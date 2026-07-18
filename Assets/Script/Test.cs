using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int n = 0;
    private float timer = 0f;
    void Awake()
    {
        UnityEngine.Debug.Log("Awake");   
    }
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        n++;

        Debug.Log(Time.deltaTime);
        if( timer >= 1f)
        {
            Debug.Log(n);
            timer = 0f;
            n = 0;
        }
    }
}
