﻿
namespace Simplex
{
    public static class StringValidationExtensions
    {
        public static StringValidationDefinition ShouldBe(this string @string)
        {
            return new StringValidationDefinition(@string);
        }
    }
}
