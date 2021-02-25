using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        //publicler pascal case yazılır
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime="Sistem bakımda.";
        public static string ProductListed="Ürünler listelendi.";
        public static string CategoryLimitIsExceded = "Katagori limiti aşıldığı için yeni ürün eklenemiyor.";
        internal static string CategoryLimitExceded;

        public static string ProductCountOfCategoryError { get; internal set; }
    }
}
