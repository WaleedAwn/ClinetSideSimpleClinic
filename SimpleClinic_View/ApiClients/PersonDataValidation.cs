using SimpleClinic_View.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleClinic_View.ApiClients
{
    public class PersonDataValidation
    {

        static public bool ValidateId(int id)
        {
            return id > 0; // Id must be positive
        }

        static public bool ValidatePersonName(string personName)
        {
            string pattern = @"^[a-zA-Z]+$"; // Accepts only letters (uppercase and lowercase)
            return !string.IsNullOrEmpty(personName) && Regex.IsMatch(personName, pattern);
        }

        static public bool ValidateDateOfBirth(string dateOfBirthInput)
        {
            DateTime parsedDate;

            // Specify the format we expect: "yyyy-MM-dd"
            string format = "yyyy-MM-dd";

            // Try to parse the input based on the exact format and ensure it's a valid date
            if (!DateTime.TryParseExact(dateOfBirthInput, format, null, System.Globalization.DateTimeStyles.None, out parsedDate))
                return false;

            // Ensure the date is within a reasonable range (not in the future and not unrealistically old)
            DateTime minDate = new DateTime(1900, 1, 1); // Lower boundary: January 1, 1900
            DateTime maxDate = DateTime.Now;             // Upper boundary: Current date

            if (parsedDate < minDate || parsedDate > maxDate)
                return false;

            // Additional checks to ensure the day and month boundaries
            int day = parsedDate.Day;
            int month = parsedDate.Month;

            // Check month is between 1 and 12
            if (month < 1 || month > 12)
                return false;

            // Ensure that the day is valid for the given month
            if (day < 1 || day > DateTime.DaysInMonth(parsedDate.Year, parsedDate.Month))
                return false;

            return true;
        }

        static public bool ValidateGender(string gender)
        {
            string[] validGenders = { "Male", "Female" }; // Accept only specific values
            return Array.Exists(validGenders, g => g.Equals(gender, StringComparison.OrdinalIgnoreCase));
        }

        static public bool ValidatePhoneNumber(string phoneNumber)
        {
            string pattern = @"^\d{9}$"; // Validates exactly 9 digits
            return Regex.IsMatch(phoneNumber, pattern);
        }


        static public bool ValidateEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email; // Valid email format
            }
            catch
            {
                return false;
            }
        }

        static public bool ValidateAddress(string address)
        {
            return !string.IsNullOrEmpty(address); // Address cannot be empty
        }

        static public bool ValidateAllPersonInfo(PersonsDTO person)
        {
            // Check if Id is invalid (0 or negative)
            if (ValidateId(person.Id))
                return false;

            // Check if PersonName is empty or less than 3 characters
            if (ValidatePersonName(person.PersonName) )
                return false;

            // Check if PhoneNumber is invalid (not 9 digits)
            if (ValidatePhoneNumber(person.PhoneNumber))
                return false;

            // Check if Gender is empty or invalid
           
            if (ValidateGender(person.Gender))
                return false;

            return true; // If all validations pass, return true
        }


    }
}
