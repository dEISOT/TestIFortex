# TestIFortex

### :zap: **Description**

Test task for IFortex. Application web service built with C# and SQLServer,
which provides functionality for managing users and their orders

### :white_check_mark: **The stack of technologies used**
:star: **API Technologies:**
- SOLID
- OOP
- DI
- REST

:desktop_computer: **Backend technologies:**
- ASP.NET Core 6
- Entity Framework Core
- SQLServer

:whale: **Containerization:**
- Docker

### :pushpin: **API Endpoints**

**Users**
  
| **HTTP METHOD** |         **ENDPOINT**         |         **DESCRIPTION**        |
|:---------------:|:----------------------------:|:------------------------------:|
|    **GET**      | `/api/v1/users/selected-user`|  Get user with max order count |
|    **GET**      | `api/v1/users/selected-users`|  Get inactive users            |

**News**

| **HTTP METHOD** |         **ENDPOINT**          |            **DESCRIPTION**           |
|:---------------:|:-----------------------------:|:------------------------------------:|
|     **GET**     |`api/v1/orders/selected-order` | Get order with max total price       |
|     **GET**     |`api/v1/orders/selected-orders`| Get orders with quantity more than 10|
