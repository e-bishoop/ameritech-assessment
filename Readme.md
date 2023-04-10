# ADS Blazor Assessment

Hello! This assessment is designed to help determine your aptitude in C#, Blazor, and HTML/CSS/JS. 

Requirements:
* [Visual Studio 2022 Community Edition](https://visualstudio.microsoft.com/vs/community/) with the ASP.Net and Web Development package

Once you have Visual Studio setup, open the ADS.Blazor.Assessment repository which contains everything you need.

This solution contains a Blazor WASM project, an ASP Core server project, and a shared library. The ASP Core 
project contains an SQLite database using EFCore that has data seeded into it on startup. There is a `Categories` table and a `Products` table.

Tasks:
1) Alter the database to account for inventory management. (EnsureDelete/Create is called on startup so no migration is needed)
2) Create a page for viewing products based on category. The product list should have the product Name, Price, Size, and Inventory Count.
3) Create a page for new products/categories
4) Include functionality to modify the inventory counts of a product

Things to consider:
* Reusability: How could you adjust your code to use more extendable and reusable components? Don't make it unnecessarily complex, but put some thought into the design itself in case you want to extend on it later.
* Clean code: Your variable names/method names should articulate your intention without the use of comments.
* Error handling: What kinds of exceptions could you run into with your design?
* Input validation: Never trust input that the user gives you.
* User Experience: Is the design intuitive to use? How could you make it easier for users to navigate? Is it visually appeasing?