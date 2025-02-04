# ABN Lookup UI Tests

This repository contains automated UI tests for the ABN Lookup website, developed using C#, .NET Core, Playwright, and SpecFlow. The tests follow Behavior-Driven Development (BDD) principles.

## Project Structure


### Important Directories and Files:
- **Features/**: Contains feature files with Gherkin syntax that describe test scenarios for the ABN Lookup search functionality.
- **StepDefinitions/**: Contains C# files with step definitions that link feature steps to code execution.
- **.playwright/**: Contains Playwright configuration and downloaded browser binaries for test execution.
- **bin/** and **obj/**: Standard output directories for compiled code and build artifacts.

## How to Run the Tests

Follow the steps below to run the tests on your machine:

### Prerequisites:
1. **.NET Core SDK**: Make sure you have .NET 6 or later installed. You can download it from [here](https://dotnet.microsoft.com/download).
2. **Playwright**: This project uses Playwright for browser automation. The necessary browsers will be installed automatically when you run the tests for the first time.
3. **SpecFlow**: This project uses SpecFlow for BDD testing, and it's already set up in the project file.

### Running the Tests:
1. **Clone the repository** to your local machine:
   ```bash
   git clone https://github.com/sotnaspaolo/abn-lookup-ui-tests.git
   cd abn-lookup-ui-tests
2. **Restore the project dependencies:**
   ```bash
   dotnet restore
3. **Run the tests**
   ```bash
   dotnet test
  This will build and run all the tests, showing the results in the terminal.

### Assumptions:

1. The tests assume that the ABN Lookup website (https://abr.business.gov.au/) is accessible and functional during testing.
2. Internet connectivity is required for Playwright to download browser binaries on the first run.
3. Test data (like ABN values) is hardcoded for this project. Future improvements could include more flexible test data setups.

### Limitations:

1. The tests assume that the ABN Lookup website (https://abr.business.gov.au/) is accessible and functional during testing.
2. Test Coverage: The current test suite covers direct hit functionality. Further tests can be added for edge cases and additional features of the ABN Lookup website.
3. Test data (like ABN values) is hardcoded for this project. Future improvements could include more flexible test data setups.

### Sample Test Result in command line:
<img width="848" alt="image" src="https://github.com/user-attachments/assets/690a7c1b-d3c5-476d-8831-be92264047bb" />


