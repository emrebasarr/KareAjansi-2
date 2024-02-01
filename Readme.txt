# KareAjansi Bitirme Projesi

N-tier katmaný uygulandý.

KareAjansi.Entity kýsmýnda Intefaces,Enums,Base ve Entitylerimin oldugu Models klasörü var.

KareAjansi.DAL kýsmý bizim veritabanýmýzýn oldugu yer. DataSeeding,Configurations,Context klasörüleri var. DataSeeding örnek veriler içermekte. Configurations kýsmýnda classlarýn,
iliskileri tanýmlanmýstýr. Context klasöründe ise KareAjansiContext.cs adýnda veritabaný var. Dependencies kýsmýnda KareAjansi.Entity ile KareAjansi.Common projeleri ile baðlý.

KareAjansi.DAL kýsmýnda yüklü olan NuGet paketler
- Microsoft.EntitFramework.SqlServer
- Microsoft.EntitFramework.Tools
- Microsoft.EntitFramework.Proxies

KareAjansi.Common içerisinde projede yardýmcý olmak için olan classlar var.

KareAjansi.IOC içerisinde ise Container adlý klasor var. Bu klasorde Dependency Injection ve AutoMapper islemlerim var.

KareAjansi.BLL kýsmý benim is katmani kýsmým. Dependencies kýsmýnda KareAjansi.DAL ile baðlý. AbstractRepositories,AbstractServices,AutoMapper,Concretes,DTOs,Services klasorleri var.

KareAjansi.BLL kýsmýnda yüklü olan NuGet paketler
- AutoMapper.Extensions.Microsoft.DependencyInjection 

KareAjansi.API kýsmý bizim verilerimizin baþka projelere veri gondermek yada almak için. Controllers klasörü var ve Depedencies kýsmýnda KareAjansi.BLL ve KareAjansi.IOC ile bagli.

KareAjansi.API kýsmýnda yüklü olan NuGet paketler
- Swashbuckle.AspNetCore (Swagger kullanmak icin)
- Microsoft.EntitFramework.Design

Son olarak KareAjansi.MVC Web sayfalarýmýn oldugu kýsým. Dependencies kýsmýnda KareAjansi.BLL ile bagli. KareAjansi.MVC icerisinde Controllers,Data,Models,Views klasorler var.

KareAjansi.MVC kýsmýnda yüklü olan NuGet paketler
- Microsoft.AspNetCore.Identity.EntityFrameworkCore (Hazýr Identity tablolar icin)



