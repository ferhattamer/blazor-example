#include <iostream>
#include <cstdlib> 
#include <ctime>  
using namespace std;

// Bilgisayarın 4 haneli sayı tutmasını sağlayan fonksiyon
void SayiTut(int *ptr)  // 4 haneli rasgele sayi üret
{
  srand (time(NULL));
  for (int i=0; i<4; i++)
  {
    // Dizinin sıradaki rakamını rasgele tut ve belleğe yaz
    *(ptr+i) = rand() % 9;
    // Eğer 1. rakam 0 seçilmişse, farklı bir rakam seçilene kadar tekrar dene
    while((i == 0) && (*ptr == 0))
    {
      *ptr = rand() % 9;
    }
    // Eğer seçilen rakam, bundan önceki rakamlardan biriyle aynı ise farklı bir rakam seçilene kadar tekrar dene
    for (int j = i; j>=0; j--)
    {
      while ((i!=j) && (*(ptr+i) == *(ptr+j)))
      {
        *(ptr+i) = rand() % 8 + 1;
      }
    }
  }
}

// Kullanıcının tahmin girmesini sağlayan fonksiyon
int TahminAl(int *TahminPtr, int *no, int *SayiPtr)
{
  bool hata = false;
  char *key;  // Kullanıcının tahmin yazacağı dinamik diziyi oluştur
  key = new char[4];
  cout<<endl<<*no<<". tahmininizi giriniz: ";
  cin>>key;
  for (int i=0; i<4; i++)
  {
    *(TahminPtr+i) = key[i]-48;
  }
   delete [] key;  // Dinamik diziyi sil
  // Alınan tahminin kurallara uygun olup olmadığını kontrol et
  // Tahminin ilk rakamı 0 olamaz
  if (*TahminPtr == 0)
  {
    cout<<"Tahminin ilk rakamı sıfır olamaz."<<endl;
    hata = true;
  }
  for (int i=0; i<4; i++)
  {
    // Tahminde eksik tuşlama yapılamaz
    if ((!hata) && ((*(TahminPtr+i) == -48)))
    {
      cout<<"Girdiğiniz sayı 4 haneli olmalıdır."<< endl;
      hata = true;
    }
    // Tahminde rakam dışında bir tuşlama yapılamaz
    if ((!hata) && ((*(TahminPtr+i) <0) || (*(TahminPtr+i) >9)))
    {
      cout<<"Yalnızca rakam tuşlayınız."<< endl;
      hata = true;
    }
    for (int j=i; j>=0; j--)
    {
      if ((!hata) && (i!=j) && (*(TahminPtr+i) == *(TahminPtr+j)))
      {
        // Tahminde aynı rakam 2 defa kullanılamaz
        cout<<"Aynı rakam birden fazla girilemez."<< endl;
        hata = true;
      }
    }
  }
  // Eğer tahminde hata yoksa + ve - leri hesaplayıp ekrana yazdır
  if(!hata)
  {
    for (int i=0; i<4; i++)  // Önce + olan sayıları bul
    {
      for (int j=0; j<4; j++)
      {
        if ((i==j) && (*(SayiPtr+i) == *(TahminPtr+j))) cout<<"+ ";
      }
    }
    for (int i=0; i<4; i++)  // Sonra - olan sayıları bul
    {
      for (int j=0; j<4; j++)
      {
        if ((i!=j) && (*(SayiPtr+i) == *(TahminPtr+j))) cout<<"- ";
      }
    }
    return 1; //  Hata yoksa 1 döndür
  }
  else return 0; // Hata varsa 0 döndür
}

int main()
{
  int *Sayi;
  Sayi = new int[4]; // Bilgisayarın tuttuğu sayıyı dinamik dizi ile oluştur

  int TahminNo = 1;  // Oyuncu kaçıncı tahminini yapıyor?
  int TahminHak = 10; // Oyuncunun toplam tahmin hakkı
  SayiTut(Sayi);
  cout<<"Sayi tutuldu. Kullanılan bellek adresi aralığı: "<<Sayi<<" - "<<Sayi+4<<endl;
  while (1==1)
  {
    // Tahmin her alındığında yeni bir dinamik dizi oluştur, karşılaştırma yaptıktan sonra sil
    int *Tahmin;
    Tahmin = new int[4];
    TahminNo = TahminNo + TahminAl(Tahmin, &TahminNo, Sayi);
    // Oyuncu sayıyı buldu
    if ((Tahmin[0]==Sayi[0]) && (Tahmin[1]==Sayi[1]) && (Tahmin[2]==Sayi[2]) && (Tahmin[3]==Sayi[3]))
    {
      cout<<"Tebrikler. Bilgisayarın tuttuğu sayıyı "<<TahminNo-1<<" tahminde buldunuz: "<<Sayi[0]<<Sayi[1]<<Sayi[2]<<Sayi[3]<<endl;
      break;
    }
    // Oyuncu verilen tahmin haklarını kullanarak sayıyı bulamadı, oyunu kaybetti
    if (TahminNo > TahminHak)
    {
      cout<<"Bilemediniz. Bilgisayarın tuttuğu sayı: "<<Sayi[0]<<Sayi[1]<<Sayi[2]<<Sayi[3]<<endl;
      break;
    }
    delete [] Tahmin;
  }

  delete [] Sayi;
  return 0;
}