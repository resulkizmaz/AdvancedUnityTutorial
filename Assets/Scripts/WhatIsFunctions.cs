using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// FONKSÝYONLARI MÝSAFÝRLÝÐE GÝTMEK GÝBÝ DÜÞÜNEBÝLÝRÝZ!!!!

public class WhatIsFunctions : MonoBehaviour 
{
    /*  ===>>> En basit SÝNGLETON yapýsý
     
    public static WhatIsFunctions instance;
    private void Awake()
    {
        instance = this;
    }

    */

    void Start()
    {
        DegersizFonsiyon();



        //Console çýktýsý : 123456
        print(ParametresizDegerliFonsiyon());



        // Ali'in Ortalamasý
        ParametreliDeðersizFonksiyon(30, 60, 90,"Ali");
        // Veli'nin Ortalamasý
        ParametreliDeðersizFonksiyon(45, 50, 30,"Veli");
        // Selami'nin Ortalamasý
        ParametreliDeðersizFonksiyon(10, 55, 75,"Selami");


    }

    void DegersizFonsiyon() // SADECE ÝHTÝYAÇ DUYULDUÐUNDA içindeki fonksiyonlarý çalýþýrýr ancak herhangi bir deðer dönürmez. (deðiþkenlere atanýlan deðer gibi)
    {
        print(" Ali Veli Selami 3'de Ondan Eveli");
    }

    int ParametresizDegerliFonsiyon() // SADECE ÝHTÝYAÇ DUYULDUÐUNDA içindeki iþlemleri yapar VE DEÐER DÖNDÜRÜR!
    {
          //FONKSÝYONUN ÝÇERÝSÝNDE YAPMAK ÝSTEDÝÐÝMÝZ ÞEYLER
          //
          //


        return 123456; 
    }

    void ParametreliDeðersizFonksiyon(int birinciYazýlý,int ikinciYazili,int ucuncuYazili, string name) // PARAMETRELER YER TUTUCU GÖREVÝ GÖRÜR!
    {
        int ortalama = (birinciYazýlý + ikinciYazili + ucuncuYazili) / 3;

        print(name +" 'nin ortalama notu : \n" +ortalama); //HERBÝR ÖÐRENCÝ ÝÇÝN AYRI AYRI NOTLARA AYNI ÝÞLEMÝ UYGULAR

        if (ortalama>=45)
        {
            print(name + " Dersten Geçti! Tebrikler");
        }
        else
        {
            print(name + " Dersten Kaldý! Seneye Tekrar Gel!");
        }

    }

}
