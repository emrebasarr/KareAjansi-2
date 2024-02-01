# KareAjansi Bitirme Projesi

N-tier katman� uyguland�.

KareAjansi.Entity k�sm�nda Intefaces,Enums,Base ve Entitylerimin oldugu Models klas�r� var.

KareAjansi.DAL k�sm� bizim veritaban�m�z�n oldugu yer. DataSeeding,Configurations,Context klas�r�leri var. DataSeeding �rnek veriler i�ermekte. Configurations k�sm�nda classlar�n,
iliskileri tan�mlanm�st�r. Context klas�r�nde ise KareAjansiContext.cs ad�nda veritaban� var. Dependencies k�sm�nda KareAjansi.Entity ile KareAjansi.Common projeleri ile ba�l�.

KareAjansi.DAL k�sm�nda y�kl� olan NuGet paketler
- Microsoft.EntitFramework.SqlServer
- Microsoft.EntitFramework.Tools
- Microsoft.EntitFramework.Proxies

KareAjansi.Common i�erisinde projede yard�mc� olmak i�in olan classlar var.

KareAjansi.IOC i�erisinde ise Container adl� klasor var. Bu klasorde Dependency Injection ve AutoMapper islemlerim var.

KareAjansi.BLL k�sm� benim is katmani k�sm�m. Dependencies k�sm�nda KareAjansi.DAL ile ba�l�. AbstractRepositories,AbstractServices,AutoMapper,Concretes,DTOs,Services klasorleri var.

KareAjansi.BLL k�sm�nda y�kl� olan NuGet paketler
- AutoMapper.Extensions.Microsoft.DependencyInjection 

KareAjansi.API k�sm� bizim verilerimizin ba�ka projelere veri gondermek yada almak i�in. Controllers klas�r� var ve Depedencies k�sm�nda KareAjansi.BLL ve KareAjansi.IOC ile bagli.

KareAjansi.API k�sm�nda y�kl� olan NuGet paketler
- Swashbuckle.AspNetCore (Swagger kullanmak icin)
- Microsoft.EntitFramework.Design

Son olarak KareAjansi.MVC Web sayfalar�m�n oldugu k�s�m. Dependencies k�sm�nda KareAjansi.BLL ile bagli. KareAjansi.MVC icerisinde Controllers,Data,Models,Views klasorler var.

KareAjansi.MVC k�sm�nda y�kl� olan NuGet paketler
- Microsoft.AspNetCore.Identity.EntityFrameworkCore (Haz�r Identity tablolar icin)



