# Projeyi çalıştırılmadan önce yapılması gerekenler
# 1. YOL
1. Proje içeriğinde bulunan WorldLeague.API katmanındaki appsettings.json dosyası üzerinden 'WorldLeague' Key değerine sahip connectionString bilgisinin localinizdeki SQL Server connectionString bilgisine göre güncellenmesi gerekmektedir.
  
2. Ayrıca 'WorldLeague' keyine sahip vermiş olduğunuz connectionString bilgisindeki 'Initial Catalog' da yazan 'WorldLeagueApp' isimli bir database'inizin SQL Server üzerinde oluşturulmuş olması gerekmektedir.

# 2. YOL
1. Proje içeriğinde bulunan WorldLeague.API katmanındaki Program.cs sınıfı üzerinde bulunan 83-87 satırlardaki Auto Migration yapılanmasını kapatarak, yukarıda bahsettiğim adımların gerçekleştirilmesi sonucu PackageConsoleManager üzerinden update-database -Context WorldLeagueDbContext demenizle birlikte Database yapılanmanız hazır hale getirilip, uygulamayı çalıştırabilirsiniz.
