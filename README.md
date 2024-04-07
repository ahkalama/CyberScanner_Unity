
Bir Main Camera Bir de Scanner Kamera oluşturup, scanner kameranin içine (child) 2 tane post process object atıyoruz, 1. pp scanner kameranın rengi (ben yeşil yaptım) 2. pp main cameraya verilecek olan bloom ve parlama efekti alıcak (ben sarı yaptım), bloom efektinin rengini ayarlamak için shader graph material oluşturuyoruz, ve materialin rengini kafamıza göre ayarlıyoruz. (ben gradient kullandım), sonra scriptleri kameralara ekleyip, taranacak objemizi kopyalıyoruz, ve child olarak içine 2. aynı objeyi yapıştırıyoruz. 1. Obje main kameranın göreceği normal obje olacak, 2. Obje 1.objenin içindeki scanner kamera çalışınca parlayacak olan obje olacak şekilde scriptlerini ayarlıyoruz.

https://github.com/ahkalama/CyberScanner_Unity/assets/116187665/f58b753e-0f08-4788-a3e4-ac9eb8c490b5

