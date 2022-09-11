using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// FONKS�YONLARI M�SAF�RL��E G�TMEK G�B� D���NEB�L�R�Z!!!!

public class WhatIsFunctions : MonoBehaviour 
{
    /*  ===>>> En basit S�NGLETON yap�s�
     
    public static WhatIsFunctions instance;
    private void Awake()
    {
        instance = this;
    }

    */

    void Start()
    {
        DegersizFonsiyon();



        //Console ��kt�s� : 123456
        print(ParametresizDegerliFonsiyon());



        // Ali'in Ortalamas�
        ParametreliDe�ersizFonksiyon(30, 60, 90,"Ali");
        // Veli'nin Ortalamas�
        ParametreliDe�ersizFonksiyon(45, 50, 30,"Veli");
        // Selami'nin Ortalamas�
        ParametreliDe�ersizFonksiyon(10, 55, 75,"Selami");


    }

    void DegersizFonsiyon() // SADECE �HT�YA� DUYULDU�UNDA i�indeki fonksiyonlar� �al���r�r ancak herhangi bir de�er d�n�rmez. (de�i�kenlere atan�lan de�er gibi)
    {
        print(" Ali Veli Selami 3'de Ondan Eveli");
    }

    int ParametresizDegerliFonsiyon() // SADECE �HT�YA� DUYULDU�UNDA i�indeki i�lemleri yapar VE DE�ER D�ND�R�R!
    {
          //FONKS�YONUN ��ER�S�NDE YAPMAK �STED���M�Z �EYLER
          //
          //


        return 123456; 
    }

    void ParametreliDe�ersizFonksiyon(int birinciYaz�l�,int ikinciYazili,int ucuncuYazili, string name) // PARAMETRELER YER TUTUCU G�REV� G�R�R!
    {
        int ortalama = (birinciYaz�l� + ikinciYazili + ucuncuYazili) / 3;

        print(name +" 'nin ortalama notu : \n" +ortalama); //HERB�R ��RENC� ���N AYRI AYRI NOTLARA AYNI ��LEM� UYGULAR

        if (ortalama>=45)
        {
            print(name + " Dersten Ge�ti! Tebrikler");
        }
        else
        {
            print(name + " Dersten Kald�! Seneye Tekrar Gel!");
        }

    }

}
