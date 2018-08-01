# Clean Architecture Kata

Kata to learn Clean Architecture and Hexagonal Architecture styles, you start with two use cases already implemented and the final solution has six use cases.

## :gem: Compiling from source

Clone this repository to your machine, compile and test it:

```sh
git clone -b kata-initial https://github.com/ivanpaulovich/clean-architecture-kata-dojo.git
cd clean-architecture-kata-dojo
./build.sh
```

## :construction_worker: Use cases

This project was designed do cover the following use cases and requirements:

1. The customer can register a new account.
2. Allow to get the customer details.
3. Allow to get the account details.
4. Allow to deposit into an existing account.
5. Allow to withdraw from an existing account.
6. Accounts can be closed only if they have zero balance.
7. Accounts does not allow to withdraw more than the current account balance.

## :memo: The Domain Model

![Domain Model](https://raw.githubusercontent.com/ivanpaulovich/ddd-tdd-rich-domain/master/docs/ddd-tdd-rich-domain-model.png)

## :computer: Tech stuff

* .NET Core / Standard
* xUnit
* Moq

## :alien: Kata

Build a Clean Architecture application with six use cases starting from the existing domain and two use cases in the `kata-initial` folder.

### :alien: Start by running the existing tests
### :alien: Create a Test Class for each use case
