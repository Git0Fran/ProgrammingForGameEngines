using UnityEngine;

public class Quit_Script : MonoBehaviour
{
    void OnMouseDown()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
