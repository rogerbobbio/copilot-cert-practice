using System;
using System.Text.RegularExpressions;

namespace EmailValidatorLib
{
    // Ejercicio: mejorar, cubrir casos edge y documentar en README
    public static class EmailValidator
    {
        // Validación simple por defecto. Mejorar con tests (internacionalización, longitudes, etc.)
        private static readonly Regex SimpleEmail = new Regex(
            @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant
        );

        public static bool IsValid(string? email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            // Normalizar
            email = email.Trim();

            // Rechazar si demasiado largo
            if (email.Length > 254) return false;

            return SimpleEmail.IsMatch(email);
        }
    }
}
