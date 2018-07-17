# FactomLibrary
Factom API Library for .net written in C#

## About
The complete solution contains two projects, the main library and the test:  
- **FactomLibrary:** The library for Factom API  
- **TestLibrary:** Project for testing purposes. Configure your own values there

This project is fully-based on [Factom API docs](https://docs.factom.com/api)

## Prerequisites
- Factom Federation (factomd, factom-walletd, factom-cli)  *You can get it* [here](https://github.com/FactomProject/distribution)
- Newtonsoft.Json 11.0.2 *(Included in the project)*
- Basic knowledge in Factom

## Installing
Just clone the project and open it in Visual Studio.

## What does this library allow me to do?
You will be able to:
- Create your own entry credit address and store it in the wallet
- Retrieve the credit balance of your public EC address
- Backup your wallet
- Create a new chain
- Make entries
- Search entries
- Retrieve details of a factoid transaction
- Retrieve administrative blocks for any given height
- Retrieve all addresses from server 

**Message: _This proyect do not implements the full Factom API.
It only implements the basic stuff to survive using the [Factom Network](https://www.factom.com/)_**

## Running the tests
Modify and Configure your own values in [test.cs](./TestLibrary/test.cs)

## Authors
- **Aziel León** - _Initial work_ - [RealALeon](https://github.com/RealALeon)

## License
This project is licensed under the MIT License - see the [LICENSE.md](./LICENSE.md) file for details.
