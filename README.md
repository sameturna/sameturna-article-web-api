# sameturna-article-web-api


Sorular: 
- Projede kullanıdığınız tasarım desenleri hangileridir? Bu desenleri neden kullandınız? 

	-Repository Pattern, veritabanına sadece bir katmandan ulaşmak için.
	-Loosely Coupled, bileşenler arası bağımlılığın en aza indirilmesi için.

- Kullandığınız teknoloji ve kütüphaneler hakkında daha önce tecrübeniz oldu mu? Tek tek yazabilir misiniz? 

	-Asp.net core ve entityframework core, c# dilinde rest ve soap api yazdım ancak sıfırdan yazdığım ilk core uygulamam oldu, IDE olarak vs code kullandım, çok zevk aldım :)
	-Nlog, daha önceden de kişisel projelerimde kullandığım loglama kütüphanesi.
	-AutoMapper, ilk defa kullandığım bir kütüphane kullanımı kolay ve hızlı.
	
- Daha geniş vaktiniz olsaydı projeye neler eklemek isterdiniz? 
	
	-Authentication için yeterli vakitim kalmadığı için mock veri ile işlem yapıyorum. 
	 Sadece bir kişinin girebildiği bir sistem tasarlayabildim vakit ayırabildiğim süremin kısıtlı olmasından dolayı.
         Dolayısı ile ilk olarak kapsamlı bir Authentication tasarlardım, üyelik sistemi eklerdim ve login ile kimlik doğrulama yapardım.
	-Oluşturduğum Article tablosuna CreateDate, CreateUser, UpdateDate, UpdateUser gibi alanlar eklerdim, daha kapsamlı bir hale getirirdim.
	
- Eklemek istediğiniz bir yorumunuz var mı? 

	-Projede Basic Authorization kullandım. username:john.smih@gmail.com  password:8b7dbd54861e461212b651213128ff5412 
	 encode edilmiş hali: am9obi5zbWloQGdtYWlsLmNvbTo4YjdkYmQ1NDg2MWU0NjEyMTJiNjUxMjEzMTI4ZmY1NDEy
	 Zaten Postman üzerinden kullandığım requestleri export ederek github repository'me  ekledim, Postman kullanıyorsanız sadece import ederek de test edebilirsiniz.
	-Veritabanı olarak mssql kullandım. Code First kullanarak tablomu oluşturdum, migration dosyalarını silmedim projenin içerisinde bakabilmeniz için. 
	 Yine de dosya dizinine sql scriptini de yazarak ekledim. Şuan eklediğim veritabanı kendi sunucumda bulunduğu için zaten hiç veritabanı oluşturmadan da 
 	 projeyi ayağa kaldırabilirsiniz dilerseniz. Cuma akşamdan, cumartesi gecesine kadar vakit ayırabildim projeye bu kadarını yapabildim, umarım olmuştur. Teşekkürler.
	

