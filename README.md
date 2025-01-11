# Crypto Price Checker

**Crypto Price Checker** is a lightweight C# console application that retrieves real-time cryptocurrency prices using the CoinGecko public API. This project is designed for simplicity, requiring no API keys or complex setup, making it perfect for developers and enthusiasts looking for quick access to crypto prices.

## Features

- Fetches real-time cryptocurrency prices in USD.
- Supports any cryptocurrency listed on CoinGecko (e.g., Bitcoin, Ethereum, Dogecoin).
- User-friendly console interface for quick queries.
- Built with clean and modular C# code for easy understanding and customization.

## Getting Started

### Prerequisites

- .NET SDK (version 6.0 or later recommended)
- Basic knowledge of running console applications

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yusiqo/Crypto-Price-Checker
   cd Crypto-Price-Checker
   ```

2. Install required dependencies:
   ```bash
   dotnet add package Newtonsoft.Json
   ```

3. Build and run the project:
   ```bash
   dotnet run
   ```

### Usage

1. Run the application:
   ```bash
   dotnet run
   ```

2. Enter the name of the cryptocurrency (e.g., `bitcoin`, `ethereum`, `dogecoin`).
3. View the real-time price in USD.

## Example

```bash
Kripto Fiyat Bilgisi Almak İçin Bir Kripto Para Birimi Girin (örnek: bitcoin):
bitcoin
bitcoin için anlık fiyat: 34,567.89 USD
```

## Technologies Used

- C#
- CoinGecko API (public, no API key required)
- Newtonsoft.Json for JSON parsing

## Contributing

Contributions are welcome! Feel free to open an issue or submit a pull request. For major changes, please open a discussion first to ensure alignment with the project's direction.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
