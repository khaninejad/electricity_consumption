# Electricity Tariff Comparison

This project is designed to compare two different types of electricity tariffs and find the one that will cost less for the customer. The tariffs being compared are the Package Tariff and the Basic Electricity Tariff.

The project contains the following classes:

    Tariff: an abstract base class that defines the interface for all tariffs.
    PackageTariffCalculator: a concrete implementation of the Tariff class that calculates the cost of the Package Tariff.
    BasicElectricityTariffCalculator: a concrete implementation of the Tariff class that calculates the cost of the Basic Electricity Tariff.
    ElectricityComparison: a class that compares the costs of both tariffs for a given consumption.

The project also includes a set of unit tests for verifying the correctness of the implementation.

To use the project, simply instantiate an instance of the ElectricityComparison class and call the Compare method with the desired consumption value. The method will return a list of Tariff objects sorted by the annual cost, with the least expensive tariff first.
