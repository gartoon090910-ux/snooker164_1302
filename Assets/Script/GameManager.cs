using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int playerScore;
    public int PlayerScore { get { return playerScore; } set { playerScore = value; } }

    [SerializeField]
    private GameObject[] ballPositions;

    [SerializeField]
    private GameObject[] ballPrefab;

    [SerializeField]
    private GameObject ballline;

    [SerializeField]
    private GameObject cueball;

    [SerializeField]
    private float xInput = 0f;

    public static GameManager instance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    private void Start()
    {
        
    }
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
            ShootBall();

        if (Keyboard.current.aKey.IsPressed || Keyboard.current.leftArrowKey.isPressed)
            xInput = -0.1f;
        else if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
            xInput = 0.1f
        else 
            xInput = 0f;

        if(Keyboard.current.backspaceKey.wasPressedThisFrame)
            StopBall();
    }

    private void SetBall(BallColor col, int i)
    {
        GameObject obj = Instantiate(ballPrefab,
                                 ballPositions[i].transform.position,
                                     Quaternion.identity);
        
        Ball b = obj.GetComponent<Ball>();
        b.SetCoLorAndPoint(col);
    }

    private void ShootBall()
    {
        Rigidbody rb = cueball.GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward * 50, ForceMode.Impulse);
        ballline.SetActive(false);
    }

    private void RotateBall()
    {
        if (cueball != null)
            cueball.transform.Rotate(0f, xInput, 0f);
    }

    private void StopBall()
    {
        Rigidbody rb = cueball.GetComponent<Rigidbody>();
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        cueball.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        ballline.SetActive(true);
    }

}
