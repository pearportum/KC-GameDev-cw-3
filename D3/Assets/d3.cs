using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d3 : MonoBehaviour
{
    string heroName = "adc";
    int heroPower = 12;
    string villainName = " xyz ";
    int villainPower = 6;
    float playerSpeed = 45.67f;

    // Start is called before the first frame update
    void Start()
    {
        print(playerSpeed);
        setSpeed(2.5f);
        print(playerSpeed);

      if (heroPower > villainPower)
      {
        print(" I am more powerful than you villain ");
      }
       else if (heroPower < villainPower) 
      {
            print(" i feel weak ");
      }
       else 
      {
          print(" Nobody's special here then ");
      }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void setSpeed(float newSpeed)
    {
        playerSpeed = newSpeed;
    }
}
