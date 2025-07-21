# Estudy-BE - E-Learning Platform Backend

[![.NET 8](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download/dotnet/8.0)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-purple.svg)](https://docs.microsoft.com/en-us/aspnet/core/)
[![Entity Framework](https://img.shields.io/badge/Entity%20Framework-8.0-green.svg)](https://docs.microsoft.com/en-us/ef/)

## 📖 Overview

Estudy-BE is a comprehensive e-learning platform backend built with ASP.NET Core 8.0 and Razor Pages. The platform provides a robust learning management system with features for course management, document handling, examination systems, and integrated payment processing.

**Domain:** [https://elearning.engineer](https://elearning.engineer)

## 🏗️ Architecture

- **Framework:** ASP.NET Core 8.0 with Razor Pages
- **Database:** SQL Server with Entity Framework Core
- **Authentication:** Cookie-based authentication with JWT support
- **Background Jobs:** Hangfire for scheduled tasks
- **File Storage:** Azure Blob Storage integration
- **Payment Processing:** MoMo and Tingee integration
- **Real-time Features:** Pusher integration for live updates

## 🚀 Features

### Core Features
- **User Management** - Registration, authentication, profile management
- **Course Management** - Course creation, enrollment, progress tracking
- **Document Management** - File upload, processing, and sharing
- **Examination System** - Quiz creation, automatic scoring, writing assessment
- **Payment Integration** - Multiple payment gateways (MoMo, Tingee)
- **Rating & Review System** - Course and document ratings with replies
- **Subscription Management** - Plan-based access control

### Advanced Features
- **AI-Powered Writing Assessment** - Automated essay scoring using Azure OpenAI
- **Speech Recognition** - Azure Speech Services integration
- **PDF Processing** - Document parsing and text extraction
- **OCR Capabilities** - Image text recognition using Tesseract
- **Background Jobs** - Order expiration, subscription management
- **Multi-language Support** - Vietnamese and English
- **Admin Dashboard** - Comprehensive management interface

## 🛠️ Technology Stack

### Backend Technologies
- ASP.NET Core 8.0
- Entity Framework Core 8.0
- SQL Server
- Hangfire (Background Jobs)
- MediatR (CQRS Pattern)

### Authentication & Security
- Cookie Authentication
- JWT Bearer Tokens
- Google OAuth 2.0
- Facebook Authentication
- BCrypt Password Hashing

### Payment Processing
- **MoMo Payment Gateway**
  - Wallet linking
  - Disbursement
  - Payment notifications
- **Tingee Banking Integration**
  - Bank account linking
  - OTP verification

### Cloud Services
- **Azure Blob Storage** - File storage
- **Azure OpenAI** - AI writing assessment
- **Azure Speech Services** - Speech recognition
- **Firebase** - Push notifications and additional services

### Third-party Libraries
- **iText7** - PDF processing
- **Tesseract** - OCR capabilities
- **EPPlus** - Excel file generation
- **SkiaSharp** - Image processing
- **PusherServer** - Real-time communication
- **MailKit** - Email services
- **RestSharp** - HTTP client

## 📦 Installation

### Prerequisites
- .NET 8.0 SDK
- SQL Server
- Visual Studio 2022 or VS Code

### Setup Instructions

1. **Clone the repository**
git clone https://github.com/yourusername/estudy-be.git
   cd estudy-be
2. **Database Setup**
   - Create a new SQL Server database
   - Update the connection string in `appsettings.json`
   - Run migrations: `dotnet ef database update`

3. **Configuration**
- Configure connection strings in `appsettings.json`
- Set up Azure services credentials
- Configure payment gateway settings (MoMo, Tingee)
- Set up Firebase configuration

4. **Install Dependencies**
   - For backend: `dotnet restore`
   - For frontend (if applicable): Navigate to the `ClientApp` folder and run `npm install`

5. **Run the Application**

## ⚙️ Configuration

### Database Connection
Update the connection string in `appsettings.json`:

### Entity Framework Commands

## 🗄️ Database Schema

The application uses the following main entities:
- **Users** - User accounts and profiles
- **Courses** - Course information and content
- **Documents** - Learning materials and files
- **Exams** - Assessments and quizzes
- **Orders** - Payment transactions
- **Wallets** - Payment method management
- **Ratings** - User feedback and reviews
- **Subscriptions** - User plan management

## 🔧 API Endpoints

### Authentication
- `POST /Auth/Login` - User login
- `POST /Auth/Register` - User registration
- `GET /Auth/Logout` - User logout

### Payment APIs
- `GET /api/BankLink/GetAllBanks` - Get supported banks
- `POST /api/BankLink/LinkWallet` - Link payment wallet
- `POST /api/BankLink/Disbursement` - Process withdrawals
- `GET /api/BankLink/GetUserWallets/{userId}` - Get user wallets

### Course Management
- Course CRUD operations
- Enrollment management
- Progress tracking

### Document Management
- File upload and processing
- Document rating and reviews
- Content organization

### Examination System
- Exam creation and management
- Automatic scoring
- Writing assessment with AI

## 🔒 Security Features

- **Authentication:** Multi-provider authentication (Google, Facebook, JWT)
- **Authorization:** Role-based access control
- **Data Protection:** Encrypted sensitive data
- **CORS:** Configured for secure cross-origin requests
- **HTTPS:** Enforced HTTPS redirection

## 📊 Background Jobs

Hangfire-powered background jobs handle:
- **Order Expiration:** Clean up expired orders every 5 minutes
- **Subscription Management:** Check and expire subscriptions hourly
- **Course Access:** Manage user course access expiration

## 🧪 Testing

The application includes comprehensive testing capabilities:
- Unit tests for core business logic
- Integration tests for API endpoints
- Performance testing for payment processing

## 📈 Monitoring & Logging

- **Logging:** Configured with Console and Debug providers
- **Hangfire Dashboard:** Monitor background jobs
- **Error Handling:** Comprehensive exception management

## 🚀 Deployment

### Production Considerations
- Configure production connection strings
- Set up SSL certificates
- Configure Azure services for production
- Set up monitoring and alerting

### Environment Variables
Key configuration settings:
- Database connection strings
- Azure service credentials
- Payment gateway configurations
- Email service settings

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Submit a pull request

## 📄 License

This project is licensed under the MIT License.

## 📞 Support

For support and questions:
- Domain: [https://elearning.engineer](https://elearning.engineer)
- Create an issue in the repository
- Contact the development team

## 🔄 Version History

- **Current Version:** .NET 8.0
- **Database:** SQL Server with Entity Framework Core 8.0
- **Architecture:** Razor Pages with API controllers

---

**Note:** This is a production-ready e-learning platform with comprehensive features for education management, payment processing, and content delivery. Ensure all sensitive configuration values are properly secured before deployment.
