using UnityEngine;
using UnityEngine.InputSystem;

public class LogicDemo : MonoBehaviour
{
        int hp = 50;
        int enemiesNear = 1;
        int ammo = 3;
        int coins = 4;
        bool isReloading = false;
        bool hasKey = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Keyboard.current.lKey.wasPressedThisFrame) Report();
        
    }
    

    private void Report()

    {
        bool canShoot;
        if(ammo > 0 && isReloading == false)
        {
            canShoot = true;
            Debug.Log($"Gracz może strzelać: {canShoot}");
        }

        bool inDanger;
         if(hp < 30 || enemiesNear > 3)
        {
            inDanger = true;
            Debug.Log($"Czy gracz w zagrożeniu: {inDanger}");
        }

        bool canOpenDoor;
         if(hasKey == true || coins >= 10)
        {
            canOpenDoor = true;
            Debug.Log($"Gracz może strzelać: {canOpenDoor}");
        }
        string status = hp > 0 ? "Żywy" : "Pokonany";
        Debug.Log(status);

        if(isReloading && HasAmmo()) isReloading = false; //Komunikat pojawia się jeden raz, ponieważ & jest używane do intów a && do bool
        if(isReloading & HasAmmo()) isReloading = false; 
    }

    private bool HasAmmo()
    {
         Debug.Log("Sprawdzam amunicję");
         return ammo > 0;
    }
}
