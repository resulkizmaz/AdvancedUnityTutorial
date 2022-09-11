using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DictionaryExample : MonoBehaviour
{
    #region  S�zl�k Yap�s�

    // Liste format�
    //List<string> list = new List<string>();

    // Array ( Dizi ) format�
    //int[] array = new int[10];


    Dictionary<string, int> amount = new Dictionary<string, int>()
    {
        { "ok",10 },
        { "iksir",20 },
        { "para",1000 },

    };

    // De�i�kenler
    int ekstraOk = 20;
    int okBedeli = 100;


    void DictionaryStarter()
    {
        print("Ok: " + amount["ok"]); // 10
        print("�ksir: " + amount["iksir"]); // 20
        print("Para: " + amount["para"]); // 1000
        print("Ekstra Ok: " + ekstraOk); // 20
        print("Ok Bedeli: " + okBedeli); // 100

        // S�zl���n "para" indexli de�eri
        if (amount["para"] > 100)
        {
            amount["ok"] += ekstraOk;
            amount["para"] -= okBedeli;
            print("Ok Say�s� " + amount["ok"] + " Kalan para " + amount["para"]); // Ok : 30  Para 900
        }
        // S�zl�kte olmayan bir de�eri manuel eklemek.
        amount["silah"] = 3;



        print("S�zl�kteki De�er Adedi: " + amount.Count); // 4
    }


    #endregion


    #region For-Foreach Yap�s�

    //De�i�kenler
    string[] pikachuSkills = { "elektrik", "hizlisaldiri", "yildirim", "parazit" }; //ARRAY

    List<string> canta = new List<string>() { "kili�", "balta", "yay" };//L�ST
    void ForForeachStarter()
    {

        for (int i = 0; i < pikachuSkills.Length; i++)
        {
            print(pikachuSkills[i]); // PikachuSkills Array'�ndaki eleman adedi
        }

        foreach (var item in canta)
        {
            /* item.Length dedi�im anda liste bazl� de�il index bazl� uzunlu�u ele al�yor
             * Yani : canta listesinde ka� eleman oldu�unu DE��L, her eleman�n toplam KA� HARFTEN olu�tu�unu ele al�yor.
             * k + i + l + i + k : old. g�re [0]'�nc� indexteki item.Lendth = 5 oluyor!!
             */
            /*
             * 
             */
            print("Canta listesindeki elemanlar�n olu�tu�u harf say�s� : " + item.Length ); 
        }



    }

    #endregion
    
    


    private void Start()
    {
        DictionaryStarter();
        ForForeachStarter();
    }
}
