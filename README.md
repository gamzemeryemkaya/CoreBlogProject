
# ASP.Net Core 5.0 Blog Projesi(Devam)
Bu proje, ASP.Net Core 5.0 kullanılarak geliştirilmiş bir Blog sitesidir. Proje, farklı teknolojileri ve konseptleri kapsayan kapsamlı bir uygulamayı temsil eder. Aşağıda proje hakkında temel bilgiler ve başlıkların bir özetini bulacaksınız.

## Proje Açıklaması
Proje, Entity Framework Core kullanarak SQL Server veritabanı üzerinde çalışan bir N Tier Architecture mimarisiyle oluşturulmuştur. Bu mimari, API'lerle desteklenir ve Code First yaklaşımıyla geliştirilmiştir. Proje, kullanıcı, yazar ve admin panelleri içerir ve birçok önemli konsepti içermektedir.


## Başlıklar

- Entity Framework Repository 
- View Component
- Fluent Validation
- Refactoring ve Generic Service
- 404 not found sayfası
- Repository Design
- Session
- Trigger
- Excel Raporu
- Ajax,Identity eklenecek 



![App-Screenshots](https://github.com/gamzemeryemkaya/CoreBlogProject/blob/master/projectimages/blog.png?raw=true)

##  Proje Özeti

Mimari: Proje, Entity Framework Core kullanılarak oluşturulmuş bir N Tier Architecture mimarisine dayanmaktadır. Bu mimari, veritabanı etkileşimi ve iş mantığı katmanları arasındaki ayrımı net bir şekilde tanımlar.

Veritabanı: Proje, SQL Server veritabanını kullanarak Code First yaklaşımıyla veritabanı işlemleri gerçekleştirir. Kullanıcılar, yazılar ve yorumlar gibi temel veri varlıkları vardır.

Kullanıcı Rolleri: Proje, kullanıcıların farklı rollerde (kullanıcı, yazar, admin) sisteme giriş yapmasına ve ilgili yetkilere sahip olmasına izin verir.

Validasyon: Fluent Validation kullanarak giriş verilerinin doğrulaması gerçekleştirilir ve hatalı girişler önlenir.

Authontecitaion: Kullanıcı oturum yönetimi, ASP.NET Core Identity kullanılarak sağlanır.

UI: Partial View, View Component, ve Layout kullanılarak kullanıcı arayüzü oluşturulur. Ajax kullanarak ekleme, silme ve güncelleme işlemleri gerçekleştirilir.

API: API üzerinden hava durumu bilgisi almak için open weather api kullanır.

Raporlar: Projede dinamik ve statik bilgilerin Excel raporları oluşturulur.

Hata Sayfaları: Proje, kullanıcılara 404 Not Found ve Access Denied gibi hata sayfaları sunar.

Yetkilendirme ve Kimlik Doğrulama: Controller seviyesinde yetkilendirme sağlanır ve Json Web Token (JWT) kullanılarak kimlik doğrulama işlemleri gerçekleştirilir.

UI Geliştirmeleri: UI bileşenleri ve Google Chart gibi görsel iyileştirmelerle kullanıcı deneyimi artırılır.


![App-Screenshots](https://github.com/gamzemeryemkaya/CoreBlogProject/blob/master/projectimages/detay.png?raw=true)

![App-Screenshots](https://github.com/gamzemeryemkaya/CoreBlogProject/blob/master/projectimages/yorum.png?raw=true)

![App-Screenshots](https://github.com/gamzemeryemkaya/CoreBlogProject/blob/master/projectimages/widget.png?raw=true)

![App-Screenshots](https://github.com/gamzemeryemkaya/CoreBlogProject/blob/master/projectimages/admin.png?raw=true)
