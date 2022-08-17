# Merhabalar istediğiniz basit projeyi buraya yükledim. Login, register ve login yaptıktan sonra oluşan 3 sayfa ve 3 controllerımız mevcut.
![register](https://user-images.githubusercontent.com/50601213/185260957-bbf5c433-708b-40e5-8b13-56f13d268443.png)
![login](https://user-images.githubusercontent.com/50601213/185260958-b8420fee-7a6a-4159-ae5c-420a9f7adcca.png)
![home page](https://user-images.githubusercontent.com/50601213/185260969-ef55b657-8daf-43a0-8522-a66349de1053.png)

# Db mantığında ise class libraryleri kullanarak dependency injection mantığı ile soyut bir db crud operasyonları gerçekleştirdim.
# İlk sayfa açıldığında controller olarak login tetikleniyor. Formda post eşliğinde dbye sorgu atıyoruz. Eğer kullanıcı varsa giriş yapıyor ve sessionda tutuyor. Böylelikle home sayfasına giriş yapılabiliyor url ile.
# Fakat kullanıcı yoksa urlde /home yazıldığında login sayfasına yönlendiriyor.
