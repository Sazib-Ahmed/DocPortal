using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL.CustomValidation
{
    public class CustomValidation
    {

        public sealed class CheckName : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if (value == null)
                {
                    return ValidationResult.Success;
                }

                string nameStr = value.ToString();

                if (Regex.IsMatch(nameStr, @"^[A-Za-z .]+$"))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Please enter a valid name. Only alphabets, spaces, and dots are allowed.");
                }
            }
        }


        public sealed class CheckAddress : ValidationAttribute
        {
            protected override ValidationResult IsValid(object address, ValidationContext validationContext)
            {
                if (address == null)
                {
                    return ValidationResult.Success; // Return success if the address is not provided
                }

                string addressStr = address.ToString();

                if (Regex.IsMatch(addressStr, @"^[A-Za-z0-9 .,-]+$"))
                {
                    return ValidationResult.Success; // Return success if the address matches the pattern
                }
                else
                {
                    return new ValidationResult("Please enter a valid address. Only alphabets, numbers, spaces, dots, commas, and hyphens are allowed.");
                }
            }
        }


        public sealed class CheckEmail : ValidationAttribute
        {
            protected override ValidationResult IsValid(object email, ValidationContext validationContext)
            {
                string emailPattern = @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$";

                if (email is string emailString && Regex.IsMatch(emailString, emailPattern))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Please enter a valid email format.");
                }
            }
        }



        public sealed class CheckPhoneNumber : ValidationAttribute
        {
            protected override ValidationResult IsValid(object phoneNumber, ValidationContext validationContext)
            {
                string phoneNumberPattern = @"^[19]\d{9}$";

                if (phoneNumber is string phoneNumberString && Regex.IsMatch(phoneNumberString, phoneNumberPattern))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Please enter a valid phone number format (e.g., 1XXXXXXXXX or 9XXXXXXXXX) with a maximum length of 10 digits.");
                }
            }
        }


        public sealed class CheckPassword : ValidationAttribute
        {
            protected override ValidationResult IsValid(object password, ValidationContext validationContext)
            {
                string passwordPattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$";

                if (password is string passwordString && Regex.IsMatch(passwordString, passwordPattern))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Please enter a valid password. It should contain at least 8 characters, including at least one uppercase letter, one lowercase letter, and one digit.");
                }
            }
        }


        public sealed class CheckNationalID : ValidationAttribute
        {
            protected override ValidationResult IsValid(object nationalID, ValidationContext validationContext)
            {
                string nationalIDPattern = @"^\d{10}(\d{3})?$";

                if (nationalID is string nationalIDString && Regex.IsMatch(nationalIDString, nationalIDPattern))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Please enter a valid national ID card number. It should be 10 or 13 digits and contain only numbers.");
                }
            }
        }

        public sealed class NoSpaceUsername : ValidationAttribute
        {
            protected override ValidationResult IsValid(object username, ValidationContext validationContext)
            {
                if (username != null && username is string v)
                {
                    string usernameStr = v;
                    if (usernameStr.Contains(" "))
                    {
                        return new ValidationResult("Username cannot contain spaces.");
                    }
                    else
                    {
                        return ValidationResult.Success;
                    }
                }
                else
                {
                    return new ValidationResult("Invalid username format.");
                }
            }
        }


        public sealed class CheckDateOfBirth : ValidationAttribute
        {
            public int AllowedAge { get; set; }

            protected override ValidationResult IsValid(object dateOfBirth, ValidationContext validationContext)
            {
                if (dateOfBirth != null && dateOfBirth is DateTime time)
                {
                    DateTime dob = time;
                    DateTime currentDate = DateTime.Now;

                    int age = currentDate.Year - dob.Year;

                    if (dob > currentDate.AddYears(-age))
                        age--;

                    if (age >= AllowedAge)
                    {
                        return ValidationResult.Success;
                    }
                }

                return new ValidationResult($"The minimum allowed age is {AllowedAge}.");
            }
        }

    }
}