# .NET Microservices Communication Lab

## Overview
This project is designed as a learning lab to explore and deepen the understanding of different communication methods between microservices. It focuses on developing a scalable and efficient platform service using **.NET Core, Kubernetes, Docker, gRPC, and SQL Server**. The architecture follows microservices principles, leveraging containerization and event-driven communication for better performance and maintainability.

## Communication Methods
The project demonstrates various communication patterns between microservices:
- **HTTP-based communication** (REST APIs)
- **Event-driven communication** (Message Brokers, Pub/Sub)
- **gRPC-based communication** (High-performance RPC framework)

## Learning Objectives
- Understand different microservices communication patterns
- Implement and compare HTTP, gRPC, and event-driven communication
- Deploy microservices in a Kubernetes environment
- Utilize containerization with Docker
- Integrate message brokers for event-driven communication

## Solution Architecture
This diagram represents the internal communication between microservices. It illustrates the different protocols used (REST API, gRPC, Event-driven) and how services exchange information through RabbitMQ.

<img src="/Diagrams/Solution Architecture.png" width="800">

## Kubernetes Architecture
This diagram shows how microservices are deployed and orchestrated in Kubernetes. It includes pod configurations, networking, and the underlying infrastructure.

<img src="/Diagrams/Kubernetes Architecture.jpg" width="800">
