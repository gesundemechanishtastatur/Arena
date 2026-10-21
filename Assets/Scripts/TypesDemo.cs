using UnityEngine;

public class TypesDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private const int MaxLives = 5;
    private readonly System.DateTime createdAt = System.DateTime.Now;
    void Start()
    {
        //Arytmetyka i rzutowanie
        Debug.Log($"7 / 2 = {7/ 2}"); // 1: przewidywane: 3 wynik : 3; 7 przez 2 == 3,5 ale otrzymałem 3 przez inta
        Debug.Log($"7 / 2f = {7 / 2f}"); // 2: przewidywane: 3,5 wynik: 3,5; w == 3,5 przez uzycie f-a
        Debug.Log($"7 % 3 = {7 % 3}"); //3: prz:3 w:1; reszta od dzielenia
        Debug.Log($"-7 / 2 = {-7 / 2}");//4: prz:-3 w: -3; to samo co pierwsze
        Debug.Log($"-7 % 3 = {-7 % 3}"); //5: prz: -3 w: -1 to samo co trzecie
        Debug.Log($"10 / 4 * 4 = {10 / 4 * 4}"); //6: prz: 8 w: 8: porzadek operacji arytmetycznych. Wynik musi byc 10 ale otrzymałem 8 przez inta
        Debug.Log($"10 / 4f * 4 = {10 / 4f * 4}"); // 7: prz: 10 w: 10: przez usycie f-a otrzymałem poprawny wynik
        Debug.Log($"(float)(7 / 2) = {(float)(7 / 2)}"); //8: prz: 3.5 w: 3: uzycie (float) nie przekonwertowało wynik 7/2 poniewaz dzielenie było na intach
        Debug.Log($"(int)3.9f = {(int)3.9f}"); //9: prz: 3 w: 3: konwersja float to int
        Debug.Log($"(int)-3.9f = {(int)-3.9f}"); //10: prz: -3 w: -3: konwersja float to int
        Debug.Log($"Mathf.FloorToInt(-3.9f) = {Mathf.FloorToInt(-3.9f)}"); //11: prz: -3 w: -4 zaokręgla w dół
        Debug.Log($"Mathf.RoundToInt(2.5f) = {Mathf.RoundToInt(2.5f)}"); //12: prz: 2 w: 2 zaokręgla w dół
        Debug.Log($"Mathf.RoundToInt(3.5f) = {Mathf.RoundToInt(3.5f)}"); //13: prz: 2 w: 4 zaokręgla do góry

        int i = 5;
        int j = i++ + ++i;
        Debug.Log($"int j = i++ + ++i = {j}"); //14: prz: 12 w: 12: działania na zmiennych

        //Tekst, znaki i granice typów
        Debug.Log($"'5' + 3 = {"5" + 3}"); // 15: w: 53: połaczenie char a int
        Debug.Log($"'5' + 3 + 5 = {"5" + 3 + 5}"); //16: w: 535 to samo co 15
        Debug.Log($"5 + 3 + '5' = {5 + 3 + "5"}"); //17: w: 85 
        Debug.Log($"'A' + 1 = {'A' + 1}"); // 18: w:66 ASCII wielkiej litery A to 65. 65 + 1 == 66
        Debug.Log($"(char)('A' + 1) = {(char)('A' + 1)}"); //19: w: B: konwersja kodu ASCII w odpowiedni symbol

        //int max = int.MaxValue + 1;
        //Debug.Log($"int.MaxValue + 1 = {max}"); //20: nie da się odpalić z powodu integer overflow

        byte b = 255;
        b++;
        Debug.Log($"b++ = {b}"); //21: w: 0 : byte overflow

        Debug.Log($"1f / 0f = {1f / 0f}"); //22: w: +nieskonczonnosc: uzycie granic
        Debug.Log($"0.1f + 0.2f == 0.3f = {0.1f + 0.2f == 0.3f}");//23: w:True : wyprowadza wynik boolean. Twierdzenie jest prawdziwe więc True
        Debug.Log($"0.1 + 0.2 == 0.3 = {0.1 + 0.2 == 0.3}"); // 24: w:False : Twierdzenie jest fałszywe więc False


        ShowTypes();
        //MaxLives = 9; The left-hand side of an assignment must be a variable, property or indexer. Probuję zmienić wartość stałej 
        //createdAt = 55;  A readonly field cannot be assigned to (except in a constructor or init-only setter of the type in which the field is defined or a variable initializer). Probuję zmienić wartość zminnej tylko do odczytu

        var level = 1;
        //level = "drugi"; level jest intem.  a ta linia się nie kompiluje bo probuję zmienić level na stringa
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ShowTypes()
    {
        int lives = 5; // ilosc zyc moze byc tylko liczba calkowita
        Debug.Log($"liczba żyć gracza = {lives}");

        int movementSpeed = 45; // moze byc double ale bardziej szczegolne znaczenia nie sa bardzo potrzebne
        Debug.Log($"prędkość gracza w jednostkach na sekundę = {movementSpeed}");

        string playerName = "Maksym Vitruk"; // imie jest stringiem
        Debug.Log($"imie gracza = {playerName}");

        bool aliveState = true; // może być albo żywy albo martwy
        Debug.Log($"czy gracz zyje  = {aliveState}");

        char actionKey = (char)69; // poniewaz to jeden symbol
        Debug.Log($"klawisz akcji zapisany jako jeden znak  = {actionKey}");

        long ranking = 10000000000; // int nie potrafi przechowywac tak duże liczby
        Debug.Log($"liczba punktów w globalnym rankingu (do 10 miliardów)  = {ranking}");

        double itemPrice = 45.99; // dla przechowywania liczb dziesiętnych
        Debug.Log($"cena przedmiotu w sklepie w złotych, z groszami  = {itemPrice}");

        //polozenie monety

        string coinColour = "GoldenMetalic"; // color jest stringiem
        Debug.Log($"kolor materiału monety  = {coinColour}");

    }
}
