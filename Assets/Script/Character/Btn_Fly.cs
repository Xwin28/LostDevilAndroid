using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_Fly : MonoBehaviour
{
    public FlyBehaviour _fly;
    // Start is called before the first frame update
   public void SetFly()
    {
        _fly.SetFlying();
    }
}
