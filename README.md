# ASEAN Phonebook (ITE1 Final Project)

A C# console application that stores students in an ASEAN phonebook, edits entries,
and searches by country. All data is kept in memory only and is lost when the program exits.

## Requirements
- .NET 8 SDK (https://dotnet.microsoft.com/download)

## How to run
```
git clone <your-repository-url>
cd AseanPhonebook
dotnet run
```

## Supported country codes
| Country | Code |
|---|---|
| Malaysia | 60 |
| Indonesia | 62 |
| Philippines | 63 |
| Singapore | 65 |
| Thailand | 66 |

Any other country code (for example 99) is rejected and the user is asked again.

## Classes
| Class | Responsibility |
|---|---|
| `Country`, `CountryRegistry` | The five valid countries and their codes |
| `PhoneNumber` | Country code, area code and number, with validation |
| `Student` | One phonebook entry; owns a `PhoneNumber` |
| `Phonebook` | Stores every `Student` in a `List<Student>`; find and search logic |
| `ConsoleInput` | Reads and validates user input |
| `PhonebookApp` | Menus and program flow |
| `Program` | Entry point |

## Development history
Development was done with Git using feature branches (see the branch list and commit history in this repository).
