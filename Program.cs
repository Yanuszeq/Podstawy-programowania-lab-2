//Zad 1

string Imie = "John";
Char Symbol_bohatera_na_mapie = '^';
int Poziom_doświadczenia = 23;
int liczba_sztuk_złota = 16;
double Waga_ekwipunku = 7.5;
bool Mapa = true;
int Liczba_treningów = 0;
Console.WriteLine("+===============================+");
Console.WriteLine("|            Ekwipunek          |");
Console.WriteLine("+===============================+");
Console.WriteLine($"|Imię: {Imie}\t\t\t|");
Console.WriteLine($"|Symbol bohatera na mapie: {Symbol_bohatera_na_mapie}\t|");
Console.WriteLine($"|Poziom doświadczenia: {Poziom_doświadczenia}\t|");
Console.WriteLine($"|Liczba sztuk złota: {liczba_sztuk_złota}\t\t|");
Console.WriteLine($"|Waga ekwipunku: {Waga_ekwipunku}\t\t|");
Console.WriteLine($"|Mapa: {Mapa}\t\t\t|");
Console.WriteLine("+===============================+");

//Zad 2
Poziom_doświadczenia += 25;
liczba_sztuk_złota -= 8;
Liczba_treningów += 1;
Console.WriteLine("\n+===============================+");
Console.WriteLine("|          Po treningu          |");
Console.WriteLine("+===============================+");
Console.WriteLine($"|Poziom doświadczenia: {Poziom_doświadczenia}\t|");
Console.WriteLine($"|Poziom doświadczenia * 2: {(Poziom_doświadczenia) * 2}\t|");
Console.WriteLine($"|złoto po treningu: {liczba_sztuk_złota}\t\t|");
Console.WriteLine($"|Złoto po otrzymaniu nagrody: {(liczba_sztuk_złota) + 15}|");
Console.WriteLine($"|Liczba treningów: {Liczba_treningów}\t\t|");
Console.WriteLine("+===============================+");

