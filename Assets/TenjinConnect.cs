using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TenjinConnect : MonoBehaviour
{
    void Start()
    {
        TenjinConnection();
    }


    public void TenjinConnection()
    {
        BaseTenjin instance = Tenjin.getInstance("FTNSVXSVBJYARJM4HPHM8X9PYIPDWO1V");

        // Sends install/open event to Tenjin
        instance.Connect();
    }
}
