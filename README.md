# Computer Shop Windows Forms Application

This Windows Forms application simulates a computer shop where users can view and select from various pre-configured computers. Each computer type (Barebone, Home, Office, Gaming, Beast) has specific hardware configurations.

## Key Features

- Implemented Builder design pattern without a director to construct different types of computers.
- Uses a ListBox to display computer names and a custom MessageBox (CdlgMessage) to show detailed computer specifications in a neatly formatted layout using Consolas 12pt font.
- Includes classes such as `Computer`, `IBuilder`, and concrete builders (`BareboneBuilder`, `HomeComputerBuilder`, etc.) for creating different computer configurations.
- The `Computer` class defines properties like Name, CPU, Cooler, Memory, SSD, Graphics, and Price, and overrides the `ToString()` method to format computer details.

## Files Structure

- `CfrmMain.cs`: Main form of the application containing the ListBox for computer selection and initialization of computer builders.
- `Computer.cs`: Defines the `Computer` class with properties and `ToString()` method for formatting details.
- `IBuilder.cs` and `AC‌​omputerBuilder.cs`: Interfaces and abstract class for the Builder design pattern implementation.
- `BareboneBuilder.cs`, `HomeComputerBuilder.cs`, etc.: Concrete builders implementing `AC‌​omputerBuilder.cs` to set specific attributes of each computer type.
- `CdlgMessage.cs`: Custom form for displaying computer details using Consolas 12pt font.

## Disclaimer

This application is created as an educational exercise to demonstrate software design patterns and does not represent actual computer configurations available for sale.


