using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    [SerializeField]
    private int points = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null && collision.gameObject != null)
        {
            Debug.Log("I got " + points.ToString() + " points");
            //collects pointsddPoints
            GamemanagerScript.Instance.AddPoints(points);

       

            //destroys itself
            Destroy(gameObject);
        }
        
    }




}
