# Organization Profile Registration System

## Laboratory Exercise 1 - Try-Catch Exception Handling

### Course
**IT1811**

### Project Name
**OrganizationProfile**

## Overview

The Organization Profile Registration System is a Windows Forms Application developed in C#. The application allows students to register for an IT organization by providing personal and academic information. The application validates user input, stores the information using a dedicated class, and displays a confirmation form before final submission.

<img width="1172" height="506" alt="image" src="https://github.com/user-attachments/assets/1b8cf112-4d2d-47b5-bd44-0e9db8a7ec70" />

The primary objective of this laboratory exercise is to demonstrate the use of:

- Methods
- Classes and Objects
- Windows Forms Controls
- Input Validation
- Regular Expressions (Regex)
- Exception Handling using Try-Catch-Finally

Based on the requirements specified in 03_Laboratory_Exercise_1.pdf and 03_Laboratory_Exercise_1_-_Method.txt.

---

# Features

## Registration Form

The Registration Form collects the following information:

- Student Number
- Last Name
- First Name
- Middle Initial
- Program
- Age
- Gender
- Birthday
- Contact Number

### Controls Used

| Control Type | Name |
|--------------|------|
| TextBox | txtStudentNo |
| TextBox | txtLastName |
| TextBox | txtFirstName |
| TextBox | txtMiddleInitial |
| TextBox | txtAge |
| TextBox | txtContactNo |
| ComboBox | cbPrograms |
| ComboBox | cbGender |
| DateTimePicker | datePickerBirthday |
| Button | btnRegister |

---

## Confirmation Form

The Confirmation Form displays all information entered by the student.

### Controls Used

| Control Type | Name |
|--------------|------|
| Label | lblStudentNo |
| Label | lblName |
| Label | lblProgram |
| Label | lblAge |
| Label | lblBirthday |
| Label | lblGender |
| Label | lblContactNo |
| Button | btnSubmit |

---

# Project Structure

```text
OrganizationProfile
│
├── Program.cs
├── StudentInformationClass.cs
│
├── frmRegistration.cs
├── frmRegistration.Designer.cs
│
├── frmConfirmation.cs
├── frmConfirmation.Designer.cs
│
└── Resources
```

---

# StudentInformationClass

The application uses a class named `StudentInformationClass` to temporarily store the student information.

## Static Variables

```csharp
public static long SetStudentNo;
public static long SetContactNo;
public static string SetProgram;
public static string SetGender;
public static string SetBirthDay;
public static string SetFullName;
public static int SetAge;
```

---

# Methods Implemented

## StudentNumber()

Converts the entered student number into a long value.

```csharp
public long StudentNumber(string studNum)
```

Returns:

```text
long
```

---

## ContactNo()

Validates the contact number using Regular Expressions.

```csharp
public long ContactNo(string contact)
```

Acceptable Format:

```text
10 to 11 numeric digits
```

Examples:

```text
09123456789
9123456789
```

---

## FullName()

Combines Last Name, First Name, and Middle Initial into a single string.

```csharp
public string FullName(
    string lastName,
    string firstName,
    string middleInitial)
```

Example Output:

```text
Dela Cruz, Juan, A
```

---

## Age()

Validates and converts the age into an integer.

```csharp
public int Age(string age)
```

Returns:

```text
int
```

---

# Validation Rules

## Student Number

- Numbers only
- Required field

---

## Contact Number

- Numbers only
- 10 to 11 digits

---

## Name Fields

- Alphabetic characters only
- Required field

---

## Age

- Numeric value only
- Must be within a valid range

---

# Exception Handling

The application uses multiple catch blocks for handling invalid user inputs.

## Exceptions Used

### FormatException

Triggered when:

```text
Invalid letters, symbols, or formatting are entered.
```

Example:

```text
Student Number = ABC123
```

---

### ArgumentNullException

Triggered when:

```text
A required field is empty.
```

Example:

```text
Last Name = Blank
```

---

### OverflowException

Triggered when:

```text
A numeric value exceeds the allowed range.
```

Example:

```text
Age = 999999999
```

---

### IndexOutOfRangeException

Used for handling invalid index access when applicable.

---

# Application Flow

```text
Start Application
        │
        ▼
Registration Form
        │
        ▼
User Enters Information
        │
        ▼
Validation Using Methods
        │
        ▼
Try-Catch Exception Handling
        │
        ▼
Save Data to StudentInformationClass
        │
        ▼
Open Confirmation Form
        │
        ▼
Display Entered Information
        │
        ▼
Submit Registration
        │
        ▼
Success Message
        │
        ▼
End
```

---

# Technologies Used

- C#
- Windows Forms
- .NET Framework
- Visual Studio
- Regular Expressions (Regex)

---

# Learning Outcomes

After completing this laboratory exercise, students should be able to:

- Create Windows Forms Applications.
- Use methods and classes effectively.
- Validate user input using Regex.
- Handle runtime errors using Try-Catch-Finally.
- Transfer data between forms.
- Apply object-oriented programming concepts.
- Improve program reliability through exception handling.

---

# Author

**Ariel S. Alberto Jr.**  
BSIT - 3B

---

# Acknowledgement

This project was developed as part of **IT1811 Laboratory Exercise 1: Try-Catch Exception Handling** using the specifications provided in 03_Laboratory_Exercise_1.pdf and 03_Laboratory_Exercise_1_-_Method.txt.
