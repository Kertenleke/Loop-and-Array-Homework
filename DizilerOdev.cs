int randomsayimiktari = 10;

Random x = new Random();

int[] sayilar = new int[randomsayimiktari];

int teksayimiktari = 0;
int çiftsayimiktari = 0;

for(int a = 0; a < randomsayimiktari; a++)
{
    int randomsayi = x.Next(0,100);
    sayilar[a] = randomsayi;

    if(randomsayi % 2 > 0)
    {
        //tek
        teksayimiktari++;
    }
    else
    {
        //Çift
        çiftsayimiktari++;
    }
}

//enb ve enk
int enb = sayilar[0];
int enk = sayilar[0];

int enbsira = 1;
int enksira = 1;

for(int a = 0; a < sayilar.Length; a++)
{
    if(sayilar[a] > enb)
    {
        enb = sayilar[a];
        enbsira = (a+1);
    }
    if(sayilar[a] < enk)
    {
        enk = sayilar[a];
        enksira = (a+1);
    }
}

Console.WriteLine("Rastgele üretilen sayılar içerisindeki en büyük sayı: " + enbsira.ToString() + ". sıradaki " + enb.ToString());
Console.WriteLine("Rastgele üretilen sayılar içerisindeki en küçük sayı: " + enksira.ToString() + ". sıradaki " + enk.ToString());

Console.WriteLine("");
Console.WriteLine(teksayimiktari.ToString() + " kadar tek sayı bulunurken,");
Console.WriteLine(çiftsayimiktari.ToString() + " kadar da çift sayı bulunur.");

Console.WriteLine("Şimdi bir sayı giriniz");

string input = Console.ReadLine();
int inputsayi;

while(!int.TryParse(input, out inputsayi))
{
    Console.WriteLine("Lütfen tekrar sadece rakamlar ile istediğiniz sayıyı girmeye deneyiniz");
    input = Console.ReadLine();
}

bool bs = false;
for(int a = 0; a < sayilar.Length; a++)
{
    if(sayilar[a] > inputsayi)
    {
        bs = true;
        Console.WriteLine("Şu anda girmiş olduğunuz sayı " + sayilar[a].ToString() + " sayısından küçüktür");
    }
}
if(!bs)
{
    Console.WriteLine("Girmiş olduğunuzdan sayıdan daha büyük bir sayı bulunmamaktadır");
}