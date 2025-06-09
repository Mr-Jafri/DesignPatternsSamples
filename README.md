# Design Patterns Demo

A comprehensive demonstration of various design patterns implemented in C#. This project showcases practical implementations of common design patterns with real-world examples.

## Overview

This project demonstrates the implementation of three fundamental design patterns:
- Singleton Pattern
- Factory Pattern
- Adapter Pattern

Each pattern is implemented with practical examples that demonstrate their use cases and benefits.

## Design Patterns Implemented

### 1. Singleton Pattern
The Singleton pattern ensures that a class has only one instance and provides a global point of access to it. In this demo, it's implemented to demonstrate how to maintain a single instance of a class throughout the application lifecycle.

### 2. Factory Pattern
The Factory pattern is demonstrated through a bank card system that creates different types of cards (Basic, Gold, Platinum, Titanium, and Premium) with varying withdrawal limits and features. This pattern encapsulates the object creation logic and provides a flexible way to create different types of objects.

### 3. Adapter Pattern
The Adapter pattern is implemented to demonstrate how to convert XML data to JSON format. It shows how to make incompatible interfaces work together by creating an adapter that converts one interface to another.

## Project Structure

```
DesignPatternsDemo/
├── DesignPatternsDemo.Console/
│   ├── Patterns/
│   │   ├── Singleton/
│   │   ├── Factory/
│   │   └── Adapter/
│   └── Program.cs
└── DesignPatternsDemo.sln
```

## Requirements

- .NET 8.0 or later
- Visual Studio 2022 or later (recommended)

## Getting Started

1. Clone the repository
2. Open the solution in Visual Studio
3. Build the solution
4. Run the application

## Usage

The demo application will run through examples of each pattern:

1. **Singleton Demo**: Demonstrates that multiple instances of the Singleton class are actually the same instance
2. **Factory Demo**: Creates different types of bank cards and demonstrates their withdrawal limits
3. **Adapter Demo**: Shows how to convert XML data to JSON format using the Adapter pattern

## Features

- Clean and well-documented code
- Practical examples of design patterns
- Console-based demonstration
- Easy to understand and extend

## Contributing

Feel free to contribute to this project by:
1. Forking the repository
2. Creating a feature branch
3. Committing your changes
4. Pushing to the branch
5. Creating a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details. 