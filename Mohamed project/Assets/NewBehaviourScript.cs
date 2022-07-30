using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{ //hero

    string hero_name = "super man";
    float hero_height = 171.2f;
    int ageh = 50;
    string hero_super_power = "flying";

    //villain

    string villian_name = "strange spider";
    float villain_height = 200.2f;
    int agev = 18;
    string villain_super_power = "fast runner";

    // Start is called before the first frame update
    void Start()
    {

        print("my name is" + hero_name + "I am " + ageh + "my height is " + hero_height + " and my super power is" + hero_super_power);
        print("my super power is" + hero_super_power);
        print("my name is" + villian_name + "I am " + agev + "a I am " + villain_height + villain_super_power);
        print("my super power is" + villain_super_power);
        print("the age diffrance is" + (ageh - agev));



    }

    // Update is called once per frame
    void Update()
    {

    }
}