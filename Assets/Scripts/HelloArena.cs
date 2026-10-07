using UnityEngine;


public class HelloArena : MonoBehaviour
{

    string name = "Joseph";
    int livesCount = 3;
    float speed = 5;
    bool easyMode = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Witaj! " + name + ", masz " + livesCount + " zycia, predkosc " + speed + "tryb łatwy: " + easyMode);
    }

}
   
