using System.Runtime.CompilerServices;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject dropItem = null;
    [SerializeField]
    private float moveSpeed = 2.0f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space is pressed");
            Instantiate(dropItem, transform.position, Quaternion.identity);
        }
        Vector3 moveDirection = Vector3.zero;

        //if(Input.GetKey(KeyCode.W))
        //{
        //    moveDirection.y = moveSpeed;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    moveDirection.y = -moveSpeed;
        //}
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection.x = -moveSpeed;


        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection.x = moveSpeed;
        }

        transform.position += moveDirection * Time.deltaTime;

        if (transform.position.x < -6)
        {
            transform.position.Set(-6, transform.position.y, transform.position.z);
        }

        


    }
}
