
# Shopping Basket Calculator

## Overview
A C# console application that calculates the total cost of shopping basket items based on individual prices and promotional offers.

## Technologies Used
- C#
- .NET 8
- xUnit
- Visual Studio Code

## Product Pricing

| Product | Price | Offer |
|---|---:|---|
| Apple | 35p | No offer |
| Banana | 20p | No offer |
| Melon | 50p | Buy One Get One Free |
| Lime | 15p | Three for the Price of Two |

## Features
- Calculates the total basket price.
- Supports multiple occurrences of products.
- Applies promotional offers automatically.
- Handles empty baskets.
- Validates unknown and blank product names.
- Uses integer pence for accurate calculations.

## Project Structure
- ShoppingBasket: Console application and pricing logic.
- ShoppingBasket.Tests: Automated xUnit test cases.

## Run the Application

```bash
dotnet run --project ShoppingBasket
```

## Run Automated Tests

```bash
dotnet test ShoppingBasket.Tests
```

## Test Results
- 24 automated tests passed.
- 0 failed.
- Manual test scenarios verified.

## Design Approach
The pricing logic is separated into a ShoppingBasketCalculator class, making it easier to maintain and test independently from the console interface.
