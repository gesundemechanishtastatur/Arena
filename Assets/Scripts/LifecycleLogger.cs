using UnityEngine;

public class LifecycleLogger : MonoBehaviour
{
    
    // Awake, OnEnable, Start, Update w różnych klatkach
    //Awake
    //Tylko Awake
    //Awake uruchamia się z grą, Start za każdym odpalaniem skryptu
    void Awake() {
        Debug.Log("Awake " + Time.frameCount); 
    }
    void  OnEnable() {
        Debug.Log("OnEnable " + Time.frameCount); 
    }

    void Start()
    {
        Debug.Log("Start " + Time.frameCount); 
    }

    
    void Update()
    {
        if(Time.frameCount == 1) Debug.Log("Update " + Time.frameCount); 
    }
    void OnDisable() {
        Debug.Log("OnDisable " + Time.frameCount); 
    }

    void OnDestroy() {
        Debug.Log("OnDestroy " + Time.frameCount); 
    }
}
