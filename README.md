# Contato API

This repository contains the source code for the Contact API, an ASP.NET Core application that manages contacts in an agenda. The API allows you to create, retrieve, edit, and delete contacts. Below are the usage instructions and details of the available routes.

## Project Structure

- **API_Contato.Context**: Contains the Entity Framework context definition for the application.
- **API_Contato.Entities**: Defines domain entities, such as `Contato`.
- **API_Contato.Controllers**: Contains controllers that expose the APIs for contact management.

## Endpoints

### Create Contact

- **Route**: `POST /contato`
- **Description**: Creates a new contact.
- **Parameters**: 
  - `contato`: JSON object with contact information (Name, Phone, Active).
- **Response**: 
  - `200 OK`: Contact successfully created.
  - `400 Bad Request`: Error in creating contact.

### Get Contact by ID

- **Route**: `GET /contato/{id}`
- **Description**: Retrieves a contact by ID.
- **Parameters**: 
  - `id`: Contact ID.
- **Response**: 
  - `200 OK`: Contact found.
  - `404 Not Found`: Contact not found.

### Get Contact by Name

- **Route**: `GET /contato/ObterPorNome`
- **Description**: Retrieves contacts that contain the specified name.
- **Parameters**: 
  - `nome`: Name or part of the contact's name.
- **Response**: 
  - `200 OK`: List of contacts found.
  - `404 Not Found`: No contacts found.

### Edit Contact by ID

- **Route**: `PUT /contato/{id}`
- **Description**: Edits the information of a contact by ID.
- **Parameters**: 
  - `id`: Contact ID.
  - `contato`: JSON object with the updated contact information.
- **Response**: 
  - `200 OK`: Contact successfully edited.
  - `404 Not Found`: Contact not found.

### Delete Contact by ID

- **Route**: `DELETE /contato/{id}`
- **Description**: Deletes a contact by ID.
- **Parameters**: 
  - `id`: Contact ID.
- **Response**: 
  - `204 No Content`: Contact successfully deleted.
  - `404 Not Found`: Contact not found.

## How to Run

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- Configured database (e.g., SQL Server, SQLite, etc.)

### Configuration

1. Clone the repository:
    ```sh
    git clone https://github.com/your-username/ContactAPI.git
    cd ContactAPI
    ```

2. Configure the connection string in the `appsettings.json` file:
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "YourConnectionStringHere"
    }
    ```

3. Apply migrations to set up the database:
    ```sh
    dotnet ef database update
    ```

### Run the Application

To start the application, use the command:
```sh
dotnet run
```

This `README.md` provides an overview of the API, describes the available endpoints, explains how to configure and run the application, and includes information on how to contribute and the project license.

### Contribution
Contributions are welcome! Feel free to open issues and pull requests for improvements and fixes.

### License
This project is licensed under the MIT License.

