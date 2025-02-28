# FizzBuzz API

This is a Web API that implements the FizzBuzz logic with division counting.

## Getting Started

1.  Open the solution in Visual Studio 2022.
2.  Build the "FizzBuzzApi" project.
3.  Run the "FizzBuzzApi" project.

## Testing

* **Postman/Swagger:**
    * Send a POST request to `[https://localhost:7071/]/FizzBuzz` with an array of integers in the request body (e.g., `[1, 3, 5, 15]`).
    * Send a GET request to `[https://localhost:7071/]/FizzBuzz/divisions` to get the division counts.
* **Unit Tests:**
    * Open the Test Explorer in Visual Studio.
    * Run all tests in the "FizzBuzzApi.Tests" project.

## Example Request (Postman)

* **POST Request:**
    * URL: `[https://localhost:7071/]/FizzBuzz`
    * Body (JSON): `[1, 3, 5, 15]`

## Note

Replace `[https://localhost:7071/]` with the actual URL your API is running on.   