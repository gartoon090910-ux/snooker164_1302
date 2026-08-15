using Unity.VisualScripting;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Ball b = other.GetComponent<Ball>();

        if (b != null)
        {
           // if (b.point == 0)
            //{
                //GameManager.instance.ShowNotiText("White ball drops!!! \nYOu Lose!");
                //Time.timeScale = 0f;
            //}
            GameManager.instance.ShowNotiText(b.point);
            Destroy(b.gameObject);
        }
    }
}
    
