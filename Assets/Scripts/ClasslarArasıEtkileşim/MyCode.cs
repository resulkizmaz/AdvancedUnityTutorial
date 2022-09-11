using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCode : MonoBehaviour
{

    void Start()
    {
        Starter();
    }
    void Starter()
    {
        KarakterMimari karakterMimari = new KarakterMimari("Unknown Player");
        print( "Mimarideki Ýsim (Default) : " + karakterMimari.playerName);

        karakterMimari.playerName = "Ali";
        print("Oyuncunun Ýsmi : " + karakterMimari.playerName);

        karakterMimari.AshFunction();
        print("Fonksiyondaki Ýsim : "+karakterMimari.playerName);
    }

}
