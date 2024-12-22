using Authentication.Interaction;
using Exceptions;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using StorageData;
using System.Security.Cryptography;

namespace Authentication;

public class UserStorage
{
    public UserStorage(TheatreDbContext context)
    {
        _dbContext = context;
    }

    public bool VerifyAdmin(AdminAuthInfo info)
    {
        var admin = _dbContext.Admin.FirstOrDefault(a => a.Name == info.Name) ??
             throw new Exception("Администратор не найден");

        (var storedHash, var inHash) = DecryptPassword(info.Password, admin.Password);

        // Сравнение нового хеша с сохраненным
        return storedHash.SequenceEqual(inHash);
    }

    public void AddAdmin(AdminAddInfo admin)
    {
        var admins = _dbContext.Admin.AsNoTracking();

        foreach (var adm in admins)
            if (adm.Name == admin.Name)
                throw new ExistsException($"Администратор с логином {admin.Name} существует");

        var pas = EncryptPassword(admin.Password);

        _dbContext.Admin.Add(new Admin() { Name = admin.Name, Password = pas });

        _dbContext.SaveChanges();
    }

    public bool VerifyViewer(ViewerAuthInfo info)
    {
        var viewer = _dbContext.Viewer.FirstOrDefault(a => a.Id == info.Id) ??
             throw new NotFoundException("Администратор не найден");

        (var storedHash, var inHash) = DecryptPassword(info.Password, viewer.Password);

        // Сравнение нового хеша с сохраненным
        return storedHash.SequenceEqual(inHash);
    }

    public void AddViewer(ViewerAddInfo viewer)
    {
        var viewers = _dbContext.Viewer.AsNoTracking();

        foreach (var v in viewers)
            if (v.Mail == viewer.Mail)
                throw new ExistsException($"Пользователь с логином {viewer.Mail} существует");

        var pas = EncryptPassword(viewer.Password);

        _dbContext.Viewer.Add(new Viewer() { Mail = viewer.Mail, Password = pas });

        _dbContext.SaveChanges();
    }

    public void UpdateViewer(ViewerUpdateInfo info)
    {
        var viewer = _dbContext.Viewer.FirstOrDefault(v => v.Id == info.Id) ??
            throw new NotFoundException("Пользователь не найден");

        if (info.Phone != null)
            viewer.Phone = info.Phone;

        if (info.FullName != null)
            viewer.FullName = info.FullName;

        _dbContext.SaveChanges();
    }


    private string EncryptPassword(string password)
    {
        // Создание объекта генератора случайных чисел
        using var rng = RandomNumberGenerator.Create();

        // Соль
        byte[] salt = new byte[16];

        // Заполнение массива случайными байтами
        rng.GetBytes(salt);

        // Генерация производного ключа с помощью PBKDF2
        byte[] derivedKey = KeyDerivation.Pbkdf2(
            password: password,  // Пароль в виде байтов
            salt: salt,          // Соль
            prf: KeyDerivationPrf.HMACSHA256,  // Алгоритм HMAC (можно использовать SHA256 или SHA1)
            iterationCount: 10000,  // Количество итераций (рекомендуется больше 1000)
            numBytesRequested: 32);  // Длина выходного ключа в байтах (например, 32 байта для AES)

        byte[] fullData = new byte[48];

        Array.Copy(salt, 0, fullData, 0, 16);
        Array.Copy(derivedKey, 0, fullData, 16, 32);

        return Convert.ToBase64String(fullData);
    }

    private (byte[], byte[]) DecryptPassword(string password, string storedData)
    {
        // Декодирование строки Base64, содержащей соль и хеш
        byte[] fullData = Convert.FromBase64String(storedData);

        // Извлечение соли (первые 16 байт)
        byte[] salt = new byte[16];
        Array.Copy(fullData, 0, salt, 0, 16);

        // Извлечение хеша пароля (оставшиеся 32 байта)
        byte[] storedHash = new byte[32];
        Array.Copy(fullData, 16, storedHash, 0, 32);

        // Генерация нового производного ключа с введенным паролем и той же солью
        byte[] inHash = KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 10000,
            numBytesRequested: 32);

        // Сравнение нового хеша с сохраненным
        return (storedHash, inHash);
    }


    private TheatreDbContext _dbContext;
}
