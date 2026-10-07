using UnityEngine;

public class Spinner : MonoBehaviour
{
    public int spinningSpeed = 90;
    public int pulseSpeed = 3;
    public double aplitude = 0.2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       /*size = GetComponent<WeshRenderer>();
       coinScale = size.bounds.size;

        for(double i = 0.8; i <= 1.2; i + 0.2)
        {
            mod = i;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * spinningSpeed);
        //transform.localScale(coinScale * mod);
        
      
    }
}
