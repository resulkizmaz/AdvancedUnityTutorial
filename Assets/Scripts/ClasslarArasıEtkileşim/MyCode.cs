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
        print( "Mimarideki �sim (Default) : " + karakterMimari.playerName);

        karakterMimari.playerName = "Ali";
        print("Oyuncunun �smi : " + karakterMimari.playerName);

        karakterMimari.AshFunction();
        print("Fonksiyondaki �sim : "+karakterMimari.playerName);
    }

}
