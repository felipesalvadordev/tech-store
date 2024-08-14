# Tech Store
Sales system developed with DDD (Domain Driven Design), Clean Architecture and Clean Code practices.  

The project uses the following practices/technologies:  

- DDD: https://www.eduardopires.net.br/2016/08/ddd-nao-e-arquitetura-em-camadas/
- CQRS: https://www.eduardopires.net.br/2016/07/cqrs-o-que-e-onde-aplicar/
- Unit Tests: Xunit
- Integration Tests: MVC Testing
- Design Patterns: Mediator is used to handle domain events
- Repository: Entity Framework and SQL Server
- Validations: Fluent Validation

# Project Anatomy 

WebApp (User Interface)
- Controllers
- ViewModels

Application (Defines the jobs the software is supposed to do and directs the expressive domain objects to work out problems. It does not contain business rules or knowledge)
- Services
- ViewModels
- Commands (Initiate a new order)
- Queries (Get orders)

Data (Persistence)
- Repository
- Database Context

Domain (Business Rules)
- Domain Classes
- Domain Services
- Repository Interfaces


Project based on the course below:  
https://desenvolvedor.io/curso-online-modelagem-de-dominios-ricos
