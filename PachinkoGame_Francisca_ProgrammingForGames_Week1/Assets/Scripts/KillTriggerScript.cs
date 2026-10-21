using UnityEngine;

public class KillTriggerScript : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision!= null && collision.gameObject!= null)
        {
            Destroy(collision.gameObject);

            Debug.Log("TRIGGERED BY " + collision.name);
        }
    }
}
