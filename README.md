
# Shopping Basket Calculator

## Overview

A C# console application that calculates the total cost of shopping basket items using individual product prices and promotional offers.

The application supports multiple occurrences of products and automatically applies the applicable discounts.

## Technologies Used

- C#
- .NET 8
- xUnit
- Visual Studio Code

## Product Pricing

| Product | Price | Promotional Offer |
|---|---:|---|
| Apple | 35p | No offer |
| Banana | 20p | No offer |
| Melon | 50p | Buy One Get One Free |
| Lime | 15p | Three for the Price of Two |

## Features

- Calculates the total cost of a shopping basket.
- Supports multiple occurrences of the same product.
- Automatically applies promotional offers.
- Handles empty baskets.
- Validates unknown and blank product names.
- Uses integer pence to ensure accurate calculations.
- Includes automated unit tests using xUnit.

## Project Structure

```text
ShoppingBasketAssessment/
│
├── ShoppingBasket/
│   ├── Program.cs
│   ├── ShoppingBasketCalculator.cs
│   └── ShoppingBasket.csproj
│
├── ShoppingBasket.Tests/
│   ├── ShoppingBasketCalculatorTests.cs
│   └── ShoppingBasket.Tests.csproj
│
├── .gitignore
└── README.md
```

## Getting Started

### Prerequisites

- .NET 8 SDK
- Visual Studio Code or another C# IDE

### Restore Dependencies

```bash
dotnet restore ShoppingBasket.Tests/ShoppingBasket.Tests.csproj
```

### Build the Application

```bash
dotnet build ShoppingBasket/ShoppingBasket.csproj
```

### Run the Application

```bash
dotnet run --project ShoppingBasket/ShoppingBasket.csproj
```

### Run Automated Tests

```bash
dotnet test ShoppingBasket.Tests/ShoppingBasket.Tests.csproj
```

## Example Pricing Scenarios

| Shopping Basket | Expected Total |
|---|---:|
| Apple, Banana | 55p |
| Melon, Melon | 50p |
| Lime, Lime, Lime | 30p |
| Apple, Apple, Banana | 90p |
| Melon, Melon, Lime, Lime, Lime | 80p |

## Test Results

- Total automated tests: 24
- Passed: 24
- Failed: 0
- Skipped: 0

Tests cover product pricing, promotional offers, mixed baskets, empty baskets, and invalid inputs.

## Design Approach

The pricing functionality is separated into a dedicated `ShoppingBasketCalculator` class.

This separation keeps the business logic independent of the console interface, improves maintainability, and makes the application easier to test using xUnit.

## Author

Yerasi Vamsi Pradeep

GitHub: https://github.com/Vamsipradeep588

