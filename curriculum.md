# Full Stack Engineering Curriculum
This is a curriculum to teach the basics of full stack software engineering using the following technologies:

 - C# ASP.NET
 - Angular (with Typescript and SASS)
 - SQL
 - Azure (for hosting)

The curriculum assumes a basic knowledge of C# but not much else.

## 1. Git and GitHub
Basics for how to use Git and GitHub.
### 1.1 Commits, Branches and Merges
Git's model for versioning the code in the repository.
### 1.2 Pushing, Pulling and Code Reviews
Sharing your code with others, and getting feedback from others.
## 2. C# in Practice
Goal of this part is to introduce some practical tips and design patterns to use object oriented C# in the real world.
### 2.1 List Processing with Lambdas
E.g. `Select`, `Where` and other methods for list processing using functional style programming.
### 2.2 Classes and Interfaces in the real world
A class describes the "shape" or "schema" of objects you might want to make, but how are they used in the real world?
### 2.2 Asynchronous Programming
When multiple instances of your code are running at once, things don't always behave in an obvious way. How to do asynchronous programming in C#, and what problems  to look out for. Where is asynchronous programming used in full stack development?  
## 3. Networking for the Web
What's actually happening when you visit a website in your browser? How do the browser, operating system, server and networking protocols fit together into something that works?

This section will be illustrated in practice with a combination of the following:

- Chrome's network tab
- Postman: https://www.postman.com/
- `HttpClient` in C#
- `curl`

### 3.1 IP
The internet's unreliable postal service. IP addresses and routing.
### 3.2 TCP
Making IP reliable and useful. Or how to turn an unreliable "fire and forget" protocol into a reliable, connection-oriented, bi-directional stream of binary data. TCP Ports.
### 3.3 TLS (or SSL, HTTPS)
Making TCP secure with certificates and encryption. Cryptographic properties of TLS, what does "secure" actually mean?
### 3.4 HTTP
HTTP is a semantic request-response protocol that uses TCP as a transport layer. What is _actually_ sent over the wire when you visit a website? HTTP verbs, Response Codes, Headers, Content Types and Compression.
### 3.5 HTTP in practice
1. Common HTTP verbs (`GET` and `POST`)
2. Common Response Codes (`200`, `404`, `500`, `301` / `302`)
3. Common Headers (`Location:`, `Cookie:`, `Set-Cookie:`, `Authorization:`)
4. Common Content Types (`text/css`, `text/html`, `text/javascript`, `application/json`, `image/png` etc.)
### 3.6 DNS
Turning domain names into IP addresses, a decentralised lookup table.
### 3.7 Putting it all together
Walkthrough of everything that happens when you visit a website in a browser.
1. DNS lookup
2. TCP Handshake
3. TLS Handshake
4. HTTP GET Request
5. Server Processing
6. HTTP Response
7. Browser Rendering + Asset Fetching
## 4. Modern Full Stack Architectures
How do today's websites work, and how is that different from in the past?
### 4.1 Static websites using html, css and javascript
How the web used to work.
### 4.2 Dynamically generated HTML
How the web has worked for a while. E.g. PHP, Razor, Ruby on Rails, JSP. A lot of the web still works this way, but this isn't the "modern" way of building web apps.
### 4.3 Single Page Applications
The modern way of building web apps. Static HTML but with APIs for data. `javascript
window.history.pushState(...)` enables this.
## 5. Basic Front End Development
The three languages that make websites.
### 5.1 HTML
Page structure and content.
### 5.2 CSS
Styling and layout. 
### 5.3 Javascript
Code for the browser.
### 5.4 Problems with these technologies
These three languages, although they've improved over time, have some fundamental problems. What are these problems and why do they make web development hard?
 1. Reusing HTML
 2. Variables in CSS
 3. Inheritance in CSS
 4. No static typing in Javascript
 5. Binding data from javascript to html
## 6. Modern Front End Development
How are modern front end apps built?
### 6.1 HTML, CSS and Javascript as a Compile Target
This unlocks usage of new front end languages, without changing browsers.
### 6.2 Angular Hello World
What does compiling front end assets looks like in the real world?
### 6.3 Angular, Sass and Typescript 
Solutions to HTML, CSS and Typescripts problems.
 1. Angular Components for HTML Reuse
 2. Variables in SASS
 3. Inheritance in SASS
 4. Static Typing in TypeScript
 5. Angular Model Binding
### 6.4 Web Assembly
A better compile target. Blazer - C# in the browser!
## 7. Back End Development
How to build the back end, or the server.
### 7.1 Hello World ASP.NET
How does a basic ASP.NET back end work?
## 8. Back End Storage
Storing things from the server.
### 8.1 Document Stores (NoSQL)
Azure Cosmos DB for storing JSON.
### 8.2 Relational Databases (SQL)
For relational data.
### 8.3 Writing files to disk on the server
Don't do this.
## 8. Building a Full Stack App
Putting it all together with a front end, back end and database.
## 9. Hosting with Azure
Putting it in the real world
