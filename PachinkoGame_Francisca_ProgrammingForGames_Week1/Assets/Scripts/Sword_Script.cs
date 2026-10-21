using UnityEngine;

public class Sword_Script : MonoBehaviour
{
    [SerializeField]
    private float direction = 1f;
    [SerializeField]
    private float swingAmount = 30f;
    [SerializeField]
    private float speed = 3f;

    float startAngle;

    void Start()
    {
        startAngle = transform.localEulerAngles.z;
    }

    void Update()
    {
        //math stuff
        float angle = startAngle + direction * Mathf.Sin(Time.time * speed) * swingAmount;
        transform.localRotation = Quaternion.Euler(0, 0, angle);
    }
}

