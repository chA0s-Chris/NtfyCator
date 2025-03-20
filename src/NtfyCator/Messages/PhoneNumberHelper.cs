// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Messages;

using System.Text.RegularExpressions;

internal static partial class PhoneNumberHelper
{
#if NETSTANDARD2_0
    private static readonly Regex _validPhoneNumbers = new(@"^\+[1-9]\d{1,14}$");
#else
    private static readonly Regex _validPhoneNumbers = ValidPhoneNumbers();

    [GeneratedRegex(@"^\+[1-9]\d{1,14}$")]
    private static partial Regex ValidPhoneNumbers();
#endif

    public static void Validate(String phoneNumber)
    {
        if (!_validPhoneNumbers.IsMatch(phoneNumber))
            throw new ArgumentException("Phone number must start with + and otherwise only contain upto 14 digits.", nameof(phoneNumber));
    }
}
