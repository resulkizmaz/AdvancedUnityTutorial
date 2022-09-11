public class KarakterMimari 
{

    public string playerName;
    public int playerExp;
    public int playerLevel;
    public int playerHealth;
    public float playerSpeed;

    public KarakterMimari(string _playerName) // Gömülü fonksiyon olarak düþünebilirsin. (KLASS FONKSÝYON - ÝSÝM FONKSÝYONU)
    {
        playerName = _playerName;
    }



    public void AshFunction()
    {
        playerName = "Ash Cachem";
        playerExp = 100;
        playerLevel = 25;
        playerHealth = 10000;
        playerSpeed = 120f;
    }
    public void PicachuFunction()
    {
        playerName = "Picachu";
        playerExp = 100;
        playerLevel = 25;
        playerHealth = 10000;
        playerSpeed = 320f;
    }
    public void TeamRocketFunction()
    {
        playerName = "Team Rocket";
        playerExp = 100;
        playerLevel = 25;
        playerHealth = 10000;
        playerSpeed = 120f;
    }
}
