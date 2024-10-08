Code First Yaklaşımı ile Veri Tabanı ve İlişkiler Oluşturma
Entity Framework Core kullanarak Code First yaklaşımını uyguladım.

User Tablosu:

Id: int, birincil anahtar ve otomatik artan.

Username: string, kullanıcının kullanıcı adı.

Email: string, kullanıcının e-posta adresi.

Post Tablosu:

Id: int, birincil anahtar ve otomatik artan.

Title: string, gönderinin başlığı.

Content: string, gönderinin içeriği.

UserId: int, gönderinin yazarı (kullanıcının kimliği).
