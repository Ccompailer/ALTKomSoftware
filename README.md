# 🏠 AltkomSoftware Microservices

Этот репозиторий содержит набор микросервисов, реализованных на C# с использованием .NET. Каждый сервис отвечает за свою функциональную область и состоит из модулей: API, бизнес-логики, тестов и (при необходимости) работы с базой данных.

## 📂 Структура проекта

```
AltkomSoftware/
├── PaymentService/
│   ├── PaymentService.Api/
│   ├── PaymentService.Test/
│   └── PaymentService/
│
├── PolicySearchService/
│   ├── PolicySearchService.Api/
│   ├── PolicySearchService.Test/
│   └── PolicySearchService/
│
├── PolicyService/
│   ├── PolicyService.Api/
│   ├── PolicyService.Test/
│   └── PolicyService/
│
├── PricingService/
│   ├── PricingService.Api/
│   ├── PricingService.Test/
│   └── PricingService/
│
├── ProductService/
│   ├── ProductService.Api/
│   ├── ProductService.Persistence/
│   ├── ProductService.Test/
│   └── ProductService/
│
├── AltkomSoftware.sln
├── .editorconfig
├── Directory.Packages.props       # Централизованное управление версиями NuGet
```

## 🛠️ Используемые технологии

- **C# / .NET**
- **ASP.NET Core**
- **Entity Framework Core** *(для Persistence слоёв)*
- **xUnit / Moq** *(для тестирования)*
- **OpenTelemetry** *(для логирования и трассировки)*
- **NuGet** *(управление зависимостями через `Directory.Packages.props`)*

## 🚀 Как начать работать с проектом

### 1. Клонируйте репозиторий:

```bash
git clone https://github.com/your-username/AltkomSoftware.git
```

### 2. Откройте решение:

Откройте файл `AltkomSoftware.sln` в **Visual Studio** или **Rider**, либо используйте командную строку:

```bash
dotnet build AltkomSoftware.sln
```

### 3. Запустите нужный сервис:

Например, чтобы запустить `ProductService.Api`:

```bash
dotnet run --project ProductService/Api/ProductService.Api.csproj
```

### 4. Запуск тестов:

```bash
dotnet test ProductService/Test/ProductService.Test.csproj
```

## 🧪 Структура сервиса (на примере ProductService)

| Проект                  | Назначение                                  |
|------------------------|---------------------------------------------|
| `ProductService.Api`   | Веб-API, обработка HTTP-запросов           |
| `ProductService`       | Основная бизнес-логика                      |
| `ProductService.Persistence` | Работа с базой данных (EF Core)         |
| `ProductService.Test`  | Юнит- и интеграционные тесты               |

## 🌐 Доступные сервисы

| Сервис                | Описание                                              |
|----------------------|-------------------------------------------------------|
| `PaymentService`     | Обработка платежей                                   |
| `PolicySearchService`| Поиск страховых полисов                              |
| `PolicyService`      | Управление страховыми полисами                      |
| `PricingService`     | Расчёт цен и тарифов                                 |
| `ProductService`     | Управление продуктами                                |


## 🔒 Лицензия

Проект распространяется под лицензией [MIT License](LICENSE).

## 👥 Авторы

- [Anton Balabanov] — [balabanov-03@list.ru]

## 📝 TODO

- [ ] Добавить Docker-файлы
- [ ] Настроить CI/CD (GitHub Actions)
- [ ] Добавить Swagger-документацию к API
- [ ] Подробнее описать каждый сервис
