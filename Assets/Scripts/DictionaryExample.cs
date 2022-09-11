using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DictionaryExample : MonoBehaviour
{
    #region  Sözlük Yapýsý

    // Liste formatý
    //List<string> list = new List<string>();

    // Array ( Dizi ) formatý
    //int[] array = new int[10];


    Dictionary<string, int> amount = new Dictionary<string, int>()
    {
        { "ok",10 },
        { "iksir",20 },
        { "para",1000 },

    };

    // Deðiþkenler
    int ekstraOk = 20;
    int okBedeli = 100;


    void DictionaryStarter()
    {
        print("Ok: " + amount["ok"]); // 10
        print("Ýksir: " + amount["iksir"]); // 20
        print("Para: " + amount["para"]); // 1000
        print("Ekstra Ok: " + ekstraOk); // 20
        print("Ok Bedeli: " + okBedeli); // 100

        // Sözlüðün "para" indexli deðeri
        if (amount["para"] > 100)
        {
            amount["ok"] += ekstraOk;
            amount["para"] -= okBedeli;
            print("Ok Sayýsý " + amount["ok"] + " Kalan para " + amount["para"]); // Ok : 30  Para 900
        }
        // Sözlükte olmayan bir deðeri manuel eklemek.
        amount["silah"] = 3;



        print("Sözlükteki Deðer Adedi: " + amount.Count); // 4
    }


    #endregion


    #region For-Foreach Yapýsý

    //Deðiþkenler
    string[] pikachuSkills = { "elektrik", "hizlisaldiri", "yildirim", "parazit" }; //ARRAY

    List<string> canta = new List<string>() { "kiliç", "balta", "yay" };//LÝST
    void ForForeachStarter()
    {

        for (int i = 0; i < pikachuSkills.Length; i++)
        {
            print(pikachuSkills[i]); // PikachuSkills Array'ýndaki eleman adedi
        }

        foreach (var item in canta)
        {
            /* item.Length dediðim anda liste bazlý deðil index bazlý uzunluðu ele alýyor
             * Yani : canta listesinde kaç eleman olduðunu DEÐÝL, her elemanýn toplam KAÇ HARFTEN oluþtuðunu ele alýyor.
             * k + i + l + i + k : old. göre [0]'ýncý indexteki item.Lendth = 5 oluyor!!
             */
            /*
             * 
             */
            print("Canta listesindeki elemanlarýn oluþtuðu harf sayýsý : " + item.Length ); 
        }



    }

    #endregion
    
    


    private void Start()
    {
        DictionaryStarter();
        ForForeachStarter();
    }
}
