using System;
using System.Collections.Generic;
using System.Text;

namespace MagazaOtomasyonu.Helpers
{
    internal static class UserSession
    {
        public static int UserId { get;  set; }
        public static string Username { get; set; } = string.Empty;
        public static string FirstName { get; set; } = string.Empty;
        public static string LastName { get; set; } = string.Empty;
        public static string RoleName { get; set; } = string.Empty;
    }
}
