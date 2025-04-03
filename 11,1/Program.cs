Console.WriteLine("inserisci la prima data separata da uno spazio (gg mm yyyy)");
string[] data1 = Console.ReadLine().Split(' ');
int giorno1 = int.Parse(data1[0]);
int mese1 = int.Parse(data1[1]);
int anno1 = int.Parse(data1[2]);
Console.WriteLine("inserisci la seconda data separata da uno spazio");
string[] data2 = Console.ReadLine().Split(' ');
int giorno2 = int.Parse(data2[0]);
int mese2 = int.Parse(data2[1]);
int anno2 = int.Parse(data2[2]);
DateTime dataCompleta1 = new DateTime(anno1,mese1,giorno1);
DateTime dataCompleta2 = new DateTime(anno2, mese2, giorno2);
if(dataCompleta1 > dataCompleta2)
{
    int temp = giorno1;
    giorno1 = giorno2;
    giorno2 = temp;
    temp = mese1;
    mese1 = mese2;
    mese2 = temp;
    temp = anno1;
    anno1 = anno2;
    anno2 = temp;
}

int differenza = (anno2-anno1)*360+(mese2-mese1)*30+(giorno2-giorno1);
int anniDifferenza = differenza / 360;
int mesiDifferenza = (differenza % 360) / 30;
int giorniDifferenza = (differenza % 360) % 30;
Console.WriteLine("la differenza tra le due date è di {0} giorni {1} mesi e {2} anni", giorniDifferenza, mesiDifferenza,anniDifferenza);