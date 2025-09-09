# 📚 Vedic Knowledge Hub

A **personalized learning platform for Indian scriptures** that provides structured access to Vedas, Upanishads, Puranas, and other ancient texts. The platform enhances learning through **personalized content delivery, interactive multimedia, progress tracking, and AI-powered Q&A**.

🌐 **Live Website:** [Visit Vedic Hub](https://yogeshsuthar1234.github.io/Sanskrit_Vedangna/Front-End/login/Login.html)

---

## ✨ Features

- 🔐 **Authentication & Authorization**  
  - JWT-based secure login system  
  - Role-based access control (users, premium subscribers, admins)  

- 📖 **Scripture Learning Modules**  
  - Structured access to Vedas, Upanishads, and auxiliary texts  
  - HTML + Tailwind-based interactive frontend  

- 📊 **User Progress Tracking**  
  - Track scripture completion percentage  
  - Save and resume learning seamlessly  

- 🤖 **AI-Powered Q&A**  
  - Integrated **DeepSeek-R2 LLM** for scripture-based intelligent question answering  

- 💳 **Subscription System**  
  - **Stripe integration** for premium membership  
  - Premium content access & improved user retention  

- 🌐 **Deployment & Performance**  
  - Deployed on **Render** for backend  
  - Optimized frontend for performance and accessibility  

---

## 🏗️ Tech Stack

**Frontend**  
- HTML5, Tailwind CSS  
- Interactive dashboards, quizzes, and multimedia integration  

**Backend**  
- ASP.NET Web API (.NET 9)  
- MongoDB for scalable data persistence  
- JWT for authentication & authorization  

**AI Integration**  
- DeepSeek-R2 LLM for Q&A  

**Payments**  
- Stripe API for subscriptions  

**Deployment**  
- Render (Backend)  
- GitHub Pages (Frontend)  

---

## 📂 Project Structure

```bash
📦 Vedic-Knowledge-Hub
├─ API                 # ASP.NET Web API project (Controllers, Configs)
├─ Application         # Business logic & Services
├─ Domain              # Models & Entities
├─ Persistence         # MongoDB context & Repositories
├─ Front-End           # HTML + Tailwind Frontend
│  ├─ Dashboard        # User dashboard & progress
│  ├─ Veda             # Vedas, Upanishads, Brahmanas, Samhitas
│  ├─ Quiz             # Quiz modules
│  ├─ DailyExclusive   # Daily learning resources
│  ├─ login            # Authentication UI
│  └─ Assets           # Images & videos
└─ SanskritPortal.sln  # Solution file

```
---

## 🚀 Getting Started

### 1. Clone the repository
```bash
git clone https://github.com/your-username/vedic-knowledge-hub.git
cd vedic-knowledge-hub
2. Backend Setup (ASP.NET Web API)
bash
Copy code
cd API
dotnet restore
dotnet run
Backend will start on: https://localhost:5001
```
### 3. Frontend Setup
- Simply open Front-End/index.html or Front-End/Dashboard/dashboard.html in a browser.
(You can also serve it using Live Server in VSCode for hot reload).

### 4. MongoDB Setup
- Install and start MongoDB locally or use MongoDB Atlas.

Update the connection string in appsettings.json.

### 5. Stripe Setup
- Add your Stripe API keys in appsettings.json under Stripe section.

## 🔐 Environment Variables

Create a `.env` file or configure in `appsettings.json`:

```json
{
  "Jwt": {
    "Key": "your-secret-key",
    "Issuer": "your-app"
  },
  "ConnectionStrings": {
    "MongoDb": "your-mongodb-uri"
  },
  "Stripe": {
    "PublishableKey": "pk_test_xxx",
    "SecretKey": "sk_test_xxx"
  }
}
```

### 👨‍💻 Author
Kirtan Soni
### 💼 Full-Stack Developer
### 🌱 Passionate about AI + Web Development
