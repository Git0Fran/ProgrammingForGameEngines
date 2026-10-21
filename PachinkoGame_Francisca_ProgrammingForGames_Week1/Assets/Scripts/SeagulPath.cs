using UnityEngine;

public class SeagulPath : MonoBehaviour
{
    public float speed = 3f;
    public float leftX = -10f;   // where it disappears
    public float rightX = 10f;   // where it respawns

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);

        if (transform.position.x < leftX)
            transform.position = new Vector3(rightX, transform.position.y, transform.position.z);
    }
}
