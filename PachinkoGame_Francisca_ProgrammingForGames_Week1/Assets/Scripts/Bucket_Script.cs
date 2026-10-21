using UnityEngine;

public class Bucket_Script : MonoBehaviour
{
    [SerializeField]
    private int attributePoints = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null && collision.gameObject != null)
        {
            Debug.Log("fell in " + attributePoints.ToString() + " bucket");
            GamemanagerScript.Instance.AddPoints(attributePoints);
        }

    }
}
