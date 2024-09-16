using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClinic_View.ApiClients
{
    public class PersonDataValidation
    {
        // Validation Functions
        /*// Method to validate the properties of a PersonDTO object
private bool IsValidPerson(PersonsDTO person)
{
    // Validate PersonName
    if (string.IsNullOrEmpty(person.PersonName) || person.PersonName.Length > 100)
    {
        return false;
    }

    // Validate DateOfBirth
    if (person.DateOfBirth == DateTime.MinValue)
    {
        return false;
    }

    // Validate Gender
    if (string.IsNullOrEmpty(person.Gender) || person.Gender.Length > 10)
    {
        return false;
    }

    // Validate PhoneNumber
    if (!string.IsNullOrEmpty(person.PhoneNumber) && !IsValidPhoneNumber(person.PhoneNumber))
    {
        return false;
    }

    // Validate Email
    if (!string.IsNullOrEmpty(person.Email) && !IsValidEmail(person.Email))
    {
        return false;
    }

    // Validate Address
    if (person.Address != null && person.Address.Length > 250)
    {
        return false;
    }

    return true;
}

// Helper method to validate phone number
private bool IsValidPhoneNumber(string phoneNumber)
{
    // Basic validation for phone number (you might want to use a more complex regex for real-world scenarios)
    return phoneNumber.Length >= 7 && phoneNumber.Length <= 15;
}

// Helper method to validate email address
private bool IsValidEmail(string email)
{
    try
    {
        var addr = new System.Net.Mail.MailAddress(email);
        return addr.Address == email;
    }
    catch
    {
        return false;
    }
}*/

    }
}
