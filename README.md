# Customer Queue Management Application

## Introduction

This project is a simple application built using C# in Visual Studio that allows users to manage a queue of up to 20 customer names. The application lets users:
- Add (enqueue) customer names to the queue.
- Remove (dequeue) customer names from the queue.
- Display the total number of customers in the queue.
- Display the full list of customer names in the queue.

The application implements a standard queue data structure and provides a simple user interface to manage the queue.

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Dependencies](#dependencies)
- [Troubleshooting](#troubleshooting)
- [Contributors](#contributors)
- [License](#license)

## Features
- **Add Customer**: Add a customer name to the queue (up to a maximum of 20 names).
- **Remove Customer**: Remove the first customer from the queue.
- **Display Queue**: View all the customer names currently in the queue.
- **Queue Count**: Display the total number of names currently in the queue.

## Installation
1. **Install Visual Studio**: Ensure that you have [Visual Studio](https://visualstudio.microsoft.com/) installed with C# development tools.
   
2. **Clone or Download the Project**:
   - Clone the repository:
     ```bash
     git clone https://github.com/your-username/customer-queue-app.git
     ```
   - Or download the ZIP file and extract it to a folder on your computer.

3. **Open the Solution**:
   - Navigate to the project folder.
   - Open the `.sln` (solution) file in Visual Studio.

4. **Build the Project**:
   - In Visual Studio, build the project by clicking on the `Build` menu and selecting `Build Solution` or pressing `Ctrl+Shift+B`.

5. **Run the Project**:
   - Press `F5` to run the application in Debug mode or navigate to `Debug > Start Debugging`.

## Usage

### Windows Forms Application (GUI)
If you are using the Windows Forms Application:
1. **Add a Name**: Enter a customer name into the text box provided and click the "Add" button to enqueue the name.
2. **Remove a Name**: Click the "Remove" button to dequeue the first customer from the queue.
3. **Display Queue**: Click the "Display Queue" button to view the current list of names in the queue. The names will appear in a list box.
4. **Queue Count**: The total number of customers in the queue will be displayed automatically when names are added or removed.

### Console Application
If you are using the console version:
1. On running the program, a menu will be displayed with options to:
   - Add a customer (enqueue).
   - Remove a customer (dequeue).
   - Display the queue.
   - Display the number of customers in the queue.
2. Follow the prompts in the console to interact with the queue.

### Example Console Menu:
```
Queue Management Application:
1. Add a Customer
2. Remove a Customer
3. Display Queue
4. Display Total Number of Customers
5. Exit
```

## Dependencies
- **.NET Framework**: Ensure that your Visual Studio environment supports the necessary .NET framework for C# projects.
- **Windows Forms**: For the GUI version, Windows Forms libraries are required.

## Troubleshooting

1. **Queue Full Error**:
   - If you attempt to add more than 20 customer names, the application will display an error message, informing you that the queue is full.

2. **Queue Empty Error**:
   - If you attempt to remove a customer from an empty queue, the application will display an error message, indicating that the queue is empty.

3. **Visual Studio Errors**:
   - If the project doesn’t build, ensure all required dependencies are installed, and your Visual Studio installation is up to date.

## Contributors
- [sijothomas97](https://github.com/sijothomas97)

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---
