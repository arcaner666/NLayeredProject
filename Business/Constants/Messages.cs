using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün adı geçersiz.";
        public static string ProductListed = "Ürünler listelendi.";
        public static string MaintenanceTime = "Sistem bakımda!";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir!";
        public static string ProductNameAlreadyExist = "Aynı isimde bir ürün zaten mevcut!";

        public static string CategoryLimitExceeded = "Kategori limiti aşıldığı için ürün eklenemiyor!";

        public static string AuthorizationDenied = "Bu işlem için yetkiniz yok!";

        public static string UserRegistered = "Kayıt işlemi başarılı.";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError = "Şifre hatalı!";
        public static string SuccessfulLogin = "Giriş işlemi başarılı.";
        public static string UserAlreadyExists = "Kullanıcı zaten sisteme kayıtlı!";
        public static string AccessTokenCreated = "AccessToken başarıyla üretildi.";
    }
}
