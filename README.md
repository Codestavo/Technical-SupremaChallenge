# Technical Challenge - Suprema
## Objective

This project aims to fulfill the technical challenge for the .NET developer position at Suprema.

## Challenge Criteria

1. **API URL**
   - The API's URL should be `http://localhost:8888/sum?upto=(number)`, where `(number)` is any natural number.

2. **HTTP Method**
   - The method should be POST.

3. **Response Format**
   - The response should be in JSON format with the following properties:
     - `boolean success`: Should return `true` if successful; otherwise, `false`.
     - `int value`: The sum of all numbers from 1 up to the given number.
     - `string error`: Should contain the corresponding error message; otherwise, `null`.


## How to Run

1. **Prerequisites**
   - .Net 8

2. **Installation**
   - Clone the repository in the desired folder using the command `git clone https://github.com/Codestavo/Technical-SupremaChallenge.git`.

3. **Usage**
   - At Application.SupremaChallenge folder, type the `dotnet run` command
   - For the application to run, change the port to 8888.
