int number = 0;// while döngüsü for döngüsü gibi ama daha dağanık gözüküyor bu da okumada biraz zorluklar yaşatabilir
while (number < 10)
{
    Console.WriteLine("Kendime inanıyorum ve bu işi başaracağım");
    number++;
}

int i = 1;
while (i <= 20)
{
    Console.WriteLine(i);
    i++;
}

int j = 1;// 20 ye kadar olan çift sayılar
while (j<=20)
{

    if (j%2==0)
    {
        Console.WriteLine("Çift sayılar:"+j);
        j++;
    }
    else
    {
        j++;
    }
}

int k = 50;//50 ile 150 sayıları arasındaki sayıların toplamı
int toplam = 0;
while (k <= 150)
{
    toplam = toplam + k;
    Console.WriteLine("sayıların toplamı="+toplam);
    k++;
}

int toplamt = 0;
int toplamç = 0;
int l = 1;
while (l <= 120)//1 ile 120 arasında k sayıları ayıt etmek için if kullanrak her tekrarda tek ve çift sayılarında toplam sağlar
{
    if (l % 2 == 0)
    {
        toplamç = toplamç + l;
        Console.WriteLine("Çift sayıların toplamı=" + toplamç);
        l++;
    }
    else
    {
        toplamt = toplamt + l;
        Console.WriteLine("Tek sayıların toplamı=");
        l++;
    }
}

