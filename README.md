# Understand-Solid-P

## Table of contents
- [Overview](#Overview)
- [Single-Responsibility-Principle](#Single-Responsibility-Principle)
- [Open/Closed-Principle](#Open/Closed-Principle)
- [Liskov-Substitution-Principle](#Liskov-Substitution-Principle)
- [Interface-Segregation-Principle](#Interface-Segregation-Principle)
- [Dependency-Inversion-Principle](#Dependency-Inversion-Principle)


## Overview
- This repository contains demonstrations of the SOLID Principle and my thoughts on it as I am in the process of learning and applying it on my path to becoming a good programmer in the future
  
## Single-Responsibility-Principle

  
## Open/Closed-Principle
- A Module should be open for extension but closed for modification or we can say that the classes you use should be open to being extended and closed to being modified

- We build an application, using SQL server. Suppose the build is completed and goes live fine.

  - Original Structure
  
    ![image](https://github.com/ninehnineh/Understand-Solid-P/assets/103179810/e164ec7e-882e-41c2-aa6a-a822fd53a968)

  - $\textcolor{gray}{\textsf{SqlServerConnection.cs}}$
  
    ![sqlconnect1](https://github.com/ninehnineh/Understand-Solid-P/assets/103179810/2b97f422-d8f3-4762-9542-4b5334a17f0e)

  - $\textcolor{gray}{\textsf{DBConnectionManager.cs}}$

    ![image](https://github.com/ninehnineh/Understand-Solid-P/assets/103179810/b175641c-ab32-4718-97ee-5737bcf62f42)

  - $\textcolor{gray}{\textsf{Program.cs}}$
  
    ![image](https://github.com/ninehnineh/Understand-Solid-P/assets/103179810/b321d505-876e-4162-8974-92479f87eda7)


  
- After a while, the boss wants to use another type of database like MySQL to serve the system. Now we will reopen the old code that has been working stably and start changing and adding some code to meet the boss's requirements.

  - New Structure
   
    ![newstructure](https://github.com/ninehnineh/Understand-Solid-P/assets/103179810/3a251357-6c14-4faa-8ca6-3081a45d6e68)

  - $\textcolor{gray}{\textsf{MySqlConnection.cs}}$
  
    ![image](https://github.com/ninehnineh/Understand-Solid-P/assets/103179810/74499f94-422b-4434-a30a-43ce7bb60c67) 

  - $\textcolor{gray}{\textsf{DBConnectionManager.cs}}$
  
    ![image](https://github.com/ninehnineh/Understand-Solid-P/assets/103179810/58fa301c-4134-4b85-b0d5-aaf3aa26e551)
  
    - we can replace/modify $\textcolor{gray}{\textsf{DBConnectionManager.cs}}$ to something better as follows.
  
      ![refactordoConnect](https://github.com/ninehnineh/Understand-Solid-P/assets/103179810/38b98341-4417-400a-a669-6b3433795156)
  
  - $\textcolor{gray}{\textsf{Program.cs}}$
  
    ![image](https://github.com/ninehnineh/Understand-Solid-P/assets/103179810/fb626e6c-cdfa-44e3-b4f7-2f67d487190d)

- Problem: it still works fine. But we violated OCP, we modified the $\textcolor{gray}{\textsf{DBConnectionManager.cs}}$, and if in the future we connect to another type of database, such as PostgreSQL, we have to do the same thing again. Adding a  $\textcolor{gray}{\textsf{PostgreSqlConnection.cs}}$ is fine because we're just adding a new class, and adding an if statement to the  $\textcolor{Yellow}{\textsf{doConnect()}}$, and we're still violating OCP.

- Solution: we will create an Interface to abstract the connection objects and the DBConnectionManager class will work only with IConnection.
  - New Structure
    
    ![image](https://github.com/ninehnineh/Understand-Solid-P/assets/103179810/0fe47b1e-f4cc-4897-9c24-23d69c6df2d8)

  - $\textcolor{Yellow}{\textsf{IConnection.cs}}$
    
    ![image](https://github.com/ninehnineh/Understand-Solid-P/assets/103179810/16e1c07e-e1db-443d-ad0d-ee499efbb531)

  - $\textcolor{gray}{\textsf{MySqlConnection.cs}}$ and $\textcolor{gray}{\textsf{SqlServerConnection.cs}}$ both implement $\textcolor{gray}{\textsf{IConnection.cs}}$
 
    ![image](https://github.com/ninehnineh/Understand-Solid-P/assets/103179810/0754cdd3-8a51-42b6-8e45-729a783a91e0)
 
    ![image](https://github.com/ninehnineh/Understand-Solid-P/assets/103179810/dc4d5772-d575-4836-9cab-1819ae2d2bf3)

  - $\textcolor{gray}{\textsf{DBConnectionManager.cs}}$
    
    ![image](https://github.com/ninehnineh/Understand-Solid-P/assets/103179810/e1c42e34-e1fa-43bc-999e-51977f9339eb)

  - $\textcolor{gray}{\textsf{Program.cs}}$
    
    ![image](https://github.com/ninehnineh/Understand-Solid-P/assets/103179810/ce7e4a4c-6806-4c49-90e1-a742fbcc7e01)

- So if we want to connect with another database like PostgreSQL, or Oracle. Just create a new class like $\textcolor{gray}{\textsf{PostgreSQLConnection.cs}}$  and  $\textcolor{gray}{\textsf{OracleConnection.cs}}$ both implement  $\textcolor{yellow}{\textsf{IConnection.cs}}$   and call it in the program and that works, we do not touch in $\textcolor{gray}{\textsf{DBConnectionManager.cs}}$
  
- Conclusion: This OCP is good due to the change of requirements, when we are writing a function, we cannot predict exactly what will happen in the future
  - so if we really know or have experience with it like "Oh!, I think this function gonna change or will have a modification in the future" if we can ensure that, let's use OCP right in the dev time.
  - If we cannot know if the function is going change or not, so not a problem, just write code that works and refactor if needed
  
## Liskov-Substitution-Principle
- Working....

## Interface-Segregation-Principle
- Working....

## Dependency-Inversion-Principle
- Working....
