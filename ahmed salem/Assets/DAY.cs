using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAY : MonoBehaviour
{
    string heroname = "ahmed";
        int herohight = 200;
    int heroage = 30;
    string herosuperpower = "fire";
    string villainName = "mohamed";
    int villainHight = 190;
    int villainAge = 20;
    string villainSuperPower = "snow";

    // Start is called before the first frame update
    void Start()
    {
        print ("hero name is " + heroname + " and the hero hight is " + herohight);
        print ("hero age is " + heroage + " and the hero super power is " + herosuperpower);
        print("villain name is " + villainName + " and the villain hight is " + villainHight);
        print("villain age is " + villainAge + " and the villain super power is " + villainSuperPower);
    }

    
}
