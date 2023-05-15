# .Net Project

ilk başta uygulamaya login sayfa ile giriş yapabilirsiniz
database'de tek bir kullanıcı bulunmaktadır

Kullanıcı adı: isubt
Şifre: isu2023

-------------------------------

Sistem'e giriş yaptıktan sonra açılan formda gerekli alanları doldurarak Database'e Contact form olarak Create işlemi gerçekleştirebilirsiniz
Form'da Email kısmındaki mail adresine de atılan kayıt mail gitmektedir.

Diğer bütün işlemlerin view'ı yoktur, sadece ApiControllerdır, Diğer mevcut işlemler:
* Bütün create edilen kayıtları listleme **GET** `/api/ContactList`
* id ile verilen kayıt get etme **GET** `api/ContactList/id`
* id ve RequestBody'de verilen contact ile kayıtı güncelleme **PUT** `api/ContactList/id`
Örnek Body (Postmanda raw json body olarak atılması lazım)
```json
{
    "Fullname" : "Fullname",
    "Email" : "Email",
    "Subject" : "Subject",
    "Message" : "Message"
}
```
* id ile verlien kayıtı silme **DELETE** `/api/ContactList/id`

