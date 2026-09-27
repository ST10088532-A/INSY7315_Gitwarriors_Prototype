# INSY7315_Gitwarriors_Part 02

_[One-sentence description of the platform : the web portal + mobile app for ITanywhere's clients and staff.]_

---

## Table of Contents

- [1. Project Overview](#1-project-overview)
- [2. Team](#2-team)
- [3. Live Deployment](#3-live-deployment)
  - [3.1 Web Application](#31-web-application)
  - [3.2 API](#32-api)
  - [3.3 Mobile Application](#33-mobile-application)
- [4. Demo Credentials](#4-demo-credentials)
- [5. Tech Stack](#5-tech-stack)
  - [5.1 Web Application](#51-web-application)
  - [5.2 Mobile Application](#52-mobile-application)
  - [5.3 Shared / Infrastructure](#53-shared--infrastructure)
- [6. Architecture](#6-architecture)
  - [6.1 System Architecture Diagram](#61-system-architecture-diagram)
  - [6.2 Web Application Architecture](#62-web-application-architecture)
  - [6.3 Mobile Application Architecture](#63-mobile-application-architecture)
  - [6.4 Design Patterns Used](#64-design-patterns-used)
- [7. Repository Structure](#7-repository-structure)
- [8. Data Model](#8-data-model)
  - [8.1 Entity Relationship Diagram](#81-entity-relationship-diagram)
  - [8.2 Ticket State Machine](#82-ticket-state-machine)
- [9. API Documentation](#9-api-documentation)
- [10. Getting Started (Local Development)](#10-getting-started-local-development)
  - [10.1 Prerequisites](#101-prerequisites)
  - [10.2 Running the Web Application + API Locally](#102-running-the-web-application--api-locally)
  - [10.3 Running the Mobile Application Locally](#103-running-the-mobile-application-locally)
  - [10.4 Environment Variables / Configuration](#104-environment-variables--configuration)
- [11. Requirements Traceability](#11-requirements-traceability)
  - [11.1 Web Application Requirements](#111-web-application-requirements)
  - [11.2 Mobile Application Requirements](#112-mobile-application-requirements)
- [12. Security](#12-security)
  - [12.1 Web Application Security](#121-web-application-security)
  - [12.2 Mobile Application Security](#122-mobile-application-security)
- [13. Accessibility](#13-accessibility)
- [14. Testing](#14-testing)
  - [14.1 Web Application / API Tests](#141-web-application--api-tests)
  - [14.2 Mobile Application Tests](#142-mobile-application-tests)
- [15. CI/CD Pipelines](#15-cicd-pipelines)
  - [15.1 Web/API Pipelines](#151-webapi-pipelines)
  - [15.2 Mobile Pipeline](#152-mobile-pipeline)
- [16. Branching Strategy](#16-branching-strategy)
- [17. Hosting & Environments](#17-hosting--environments)
- [18. Non-Functional Requirements Evidence](#18-non-functional-requirements-evidence)
- [19. Presentation](#19-presentation)
- [20. Known Limitations & Future Work](#20-known-limitations--future-work)
- [21. References](#21-references)

---

## 1. Project Overview

_[What the system is, who it's for (IT Anywhere, an MSSP/IT auditing firm, and its client organisations), and the problem it solves. 2–4 sentences, adapted from the Part 1 proposal introduction.]_

---

## 2. Team

_[Name — student number — role/primary responsibility (e.g. Web Lead, Mobile Lead, API, DB/ERD, DevOps).]_

| Name | Student Number | Primary Responsibility |
|---|---|---|
| | | |
| | | |
| | | |

---

## 3. Live Deployment

### 3.1 Web Application

_[Hosted URL for the MVC front end.]_

### 3.2 API

_[Hosted URL for the API base address, plus the SwaggerI URL.]_

### 3.3 Mobile Application

_[Link to the signed release APK { e.g. a GitHub Release asset — plus the minimum Android version supported.}]_

---

## 4. Demo Credentials

_[One row per role, reset/seeded before each demo. Never real client data.]_

| Role | Email | Password | Notes |
|---|---|---|---|
| Client User | | | |
| Client User (org admin) | | | |
| Technician | | | |
| Account Manager | | | |

---

## 5. Tech Stack

### 5.1 Web Application

_[ASP.NET Core MVC version, ASP.NET Core Web API version, ORM, Postgres, key NuGet packages.]_

### 5.2 Mobile Application

_[Kotlin version, Jetpack Compose, minimum/target SDK, Retrofit/OkHttp, Room, key libraries.]_

### 5.3 Shared / Infrastructure

_[Docker, GitHub Actions, hosting provider(s), database host, container registry.]_

---

## 6. Architecture

### 6.1 System Architecture Diagram

_[Diagram showing: Web (browser) → ITAConnect.Web (MVC) → ITAConnect.Api → PostgreSQL, and Android app → ITAConnect.Api directly, both clients hitting the same API.]_

### 6.2 Web Application Architecture

_[Diagram/description of the two-project layering: Controllers → Services → Repositories → EF Core, and where Patterns/, Security/, Middleware/ sit.]_

### 6.3 Mobile Application Architecture

_[Diagram/description of MVVM: Compose Screens → ViewModels → Repositories → ApiService, and where SessionManager/Room caching sit.]_

### 6.4 Design Patterns Used

_[Short table: pattern name → where it lives → what it's for. E.g. Factory (ReportFactory), Facade (ReportingFacade), Observer (AuditObserver), State (TicketStateMachine), Repository, Singleton (SessionManager, mobile).]_

---

## 7. Repository Structure

```
/
├── api/            _[ITAConnect.Api — ASP.NET Core Web API]_
├── web/            _[ITAConnect.Web — ASP.NET Core MVC]_
├── mobile/         _[ITA Connect Android app — Kotlin/Jetpack Compose]_
├── docs/           _[ERD, architecture diagrams, presentation slides, screenshots]_
└── .github/
    └── workflows/  _[CI/CD pipeline definitions]_
```

_[Expand each top-level folder into its actual sub-structure once it exists — see the ASP.NET solution structure doc and the mobile architecture doc for the target layout of `api/`, `web/`, and `mobile/` respectively.]_

---

## 8. Data Model

### 8.1 Entity Relationship Diagram

_[The single merged ERD covering organizations, users, tickets, ticket_notes, assets, invoices, reports, audit_logs — image or link into `docs/`.]_

### 8.2 Ticket State Machine

_[Diagram of the allowed status transitions (New → Assigned → In Progress → Resolved → Reopened/Closed/Cancelled) and which roles can trigger which transition.]_

---

## 9. API Documentation

_[Link to the hosted Swagger/OpenAPI UI (Section 3.2), plus a short note on API versioning (`/api/v1`) and authentication (Bearer JWT).]_

---

## 10. Getting Started (Local Development)

### 10.1 Prerequisites

_[.NET SDK version, Docker/Docker Compose, Android Studio version, JDK version, PostgreSQL (or Docker image).]_

### 10.2 Running the Web Application + API Locally

_[Step-by-step: clone, restore, configure connection string/env vars, run migrations, `dotnet run` for both projects, or `docker compose up`.]_

### 10.3 Running the Mobile Application Locally

_[Step-by-step: open in Android Studio, set the API base URL build config for local vs hosted, run on emulator/device.]_

### 10.4 Environment Variables / Configuration

_[Table of required env vars/config keys for `api/` and `web/` — names only, no real secret values.]_

| Variable | Used by | Purpose |
|---|---|---|
| | | |

---

## 11. Requirements Traceability

### 11.1 Web Application Requirements

_[Link to or embed the FR → user story → screen → endpoint → status table from the Web Application Requirements Specification.]_

### 11.2 Mobile Application Requirements

_[Same, for the mobile app's own functional requirements once that spec is written.]_

---

## 12. Security

### 12.1 Web Application Security

_[Threat → mitigation table: brute force/lockout, XSS, SQL injection, CSRF, tenant isolation, security headers, secrets management.]_

### 12.2 Mobile Application Security

_[Secure token storage, network security config (no cleartext), R8/minification, no secrets in the APK.]_

---

## 13. Accessibility

_[WCAG 2.2 AA evidence for the web app — contrast, keyboard navigation, screen reader labels; TalkBack/semantics evidence for mobile. Link to axe/Lighthouse reports if automated.]_

---

## 14. Testing

### 14.1 Web Application / API Tests

_[Unit test coverage summary, integration test coverage (incl. tenant-isolation tests), how to run them, coverage report link.]_

### 14.2 Mobile Application Tests

_[Unit tests (ViewModels, repositories), instrumented/UI tests, how to run them.]_

---

## 15. CI/CD Pipelines

### 15.1 Web/API Pipelines

_[Status badges. What each workflow does: build, test, deploy-on-merge.]_

### 15.2 Mobile Pipeline

_[Status badge. Gradle build/lint/test, APK artifact/release on tag.]_

---

## 16. Branching Strategy

_[Diagram or short description: main / develop / feature branches, PR requirements, protected branches.]_

---

## 17. Hosting & Environments

_[Table: environment (staging/production) → what's hosted where → who has access → how a deploy happens. Brief rationale for the hosting choice.]_

| Environment | Web | API | Database | Trigger |
|---|---|---|---|---|
| Staging | | | | merge to `develop` |
| Production | | | | merge to `main` |

---

## 18. Non-Functional Requirements Evidence

_[Performance (dashboard load time), availability/uptime monitor screenshot, any load-test results — mapped back to the NFRs stated in the Part 1 proposal.]_

---

## 19. Presentation

_[Link to slides (PDF/PPTX), and a link to the backup recorded demo video.]_

---

## 20. Known Limitations & Future Work

_[Honest list of what's out of scope for Task 2 / not fully implemented, and what would come next.]_

---

## 21. References

_[Any external docs, libraries, or articles cited, matching the referencing style used in the Part 1 proposal.]_
