Bookkeeping App

Bookkeeping App is a simple .NET console application that does automated bookkeeping for a small business. It prompts the user to enter the business name, revenue, and expenses, calculates the profit, and stores the bookkeeping information in a PostgreSQL database.
How to Run the Code

    Install the Npgsql package: You can do this using the NuGet Package Manager in Visual Studio or by adding the package reference to your project file.

Install-Package Npgsql

    Create a PostgreSQL database and a table: You can do this using the psql command line tool or a GUI tool like pgAdmin.

scss

CREATE DATABASE bookkeeping;
CREATE TABLE bookkeeping_info (
    id SERIAL PRIMARY KEY,
    business_name VARCHAR(255),
    revenue NUMERIC(18,2),
    expenses NUMERIC(18,2),
    profit NUMERIC(18,2),
    created_at TIMESTAMP DEFAULT NOW()
);

    Clone or download the code from the repository.

    Open the code in Visual Studio or another .NET IDE.

    Build the solution.

    Run the code.

    Enter the PostgreSQL connection string when prompted.

    Enter the business name, revenue, and expenses when prompted.

    The bookkeeping information will be stored in the bookkeeping_info table in the PostgreSQL database.

Code Documentation

The code is organized into a single C# class called Program. It uses the Npgsql namespace to connect to a PostgreSQL database and the System.IO namespace to read user input and write to the console.

The Main method is the entry point of the application. It starts by displaying a welcome message and prompting the user to enter the PostgreSQL connection string.

It then opens a connection to the PostgreSQL database using the NpgsqlConnection class. If the connection is successful, it prompts the user to enter the business name, revenue, and expenses.

It calculates the profit by subtracting the expenses from the revenue. It then inserts the bookkeeping information into the bookkeeping_info table using a parameterized SQL query and the NpgsqlCommand class.

If the insertion is successful, it displays a message indicating how many rows were inserted. If an error occurs, it displays an error message.

Finally, it waits for the user to press a key before exiting the application.

That's it! With these simple steps, you can use the Bookkeeping App to automate your small business bookkeeping and store your financial data in a PostgreSQL database.
