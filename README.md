# GIP-project
Informatics project made on my last year highschool

This is an application that focuses on shops, with the purpose of giving an overview of products and customers
It provides a few things:
- Support for creating new products, modyfying or deleting those
- Gives an overview of customers
- A small (not fully implemented) feature that allows you to add purchases from the store

This project is made in C#, .NET version v4.7.2, working with Windows Forms
We store all the data the application needs in a MySQL database, the database path is hardcoded (as we were free to choose our database)

The design of the application is set out like this: 
- A Business package which covers all the business objects, like Customer, Product, etc.
- A Presentation package which basically contains all the Windows Forms stuff, for making the GUI
- A DataAccess package which has classes to interact with the database, taking all CRUD operations into account:
  - Create
  - Read
  - Update
  - Insert

This definitly isn't working perfect but be free to have some inspiration by this project

![image](https://user-images.githubusercontent.com/74827262/180030368-f9963d4f-6377-41ce-8f29-4d0804c84af8.png)
