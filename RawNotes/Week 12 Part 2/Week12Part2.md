---
marp: true
<style>
img[alt~="center"] {
  display: block;
  margin: 0 auto;
}
</style>
---
# Programming in .NET
#### by Prof. Trishan Gunness 
---
# Announcements  

- Assignment Lab 5 due **December 8th 2023 11:59pm (no late days)**
  - See ["How to upload your game to Canvas"](https://www.youtube.com/watch?v=PNpVoE8w2r8)
---
<style scoped>section { font-size: 23px; }</style>
# Recap:
- Week 1 - Introduced .NET & Visual Studio
- Week 2 - Introduced C# Language
- Week 3 - Introduced Lists and LINQ
- Week 4 - OOP Fundamentals - Classes and Objects
- Week 5 - OOP Fundamentals - Relationships
- Week 6 - GUI - Forms and Events
- Week 7 - Midterm
- Week 8 Part 1 - Strings, Characters, Files & Streams, Serialization
- Week 8 Part 2 - Gaming I
- Week 9 Part 1 - Serialization, Classes File and Directory, Searching and Sorting
- Week 9 Part 2 - Gaming II
- Week 10 Part 1 - Generics
- Week 11 - Databases
- **Week 12 - LINQ a deeper look**
- Week 13 - Exam Review
---

# Today

## Topics
- LINQ to SQL
- Generic Repository Pattern

---
# RECAP: Provisioning Database

- We will use the Northwind database from Microsoft for this week.

- Know how to provision a database from a given SQL Script is vital

---

# DEMO - Generic Repository Pattern

---

# Exercise - Using Generic Repository to Simplify Code

```
1. Setup:
   - Create a new Console Application
   - Create a LINQ to SQL data context for the Northwind database.
   - Create a Generic Repository to be used throughout the exercise

2. Display Customers
   - Write a function to retrieve and display the names of all customers

3. Display Products Over $50
   - Write a function to retrieve and display the product names and prices for products with a price greater than $50.

4. Display Orders with Customer
   - Write a function that joins the "Orders" and "Customers" tables to display the order ID, customer name, and order date.

5. Display Total Products per Category
   - Write a function to find and display the total number of products available in each category.

6. Insert New Customer
   - Write a function to insert a new customer into the "Customers" table programmatically.

7. Update Product Prices
   - Write a function to update the price of all products in the "Products" table by increasing them by 10%.

8. Delete Order
   - Write a function to delete a specific order from the "Orders" table.

9. Exception Handling
   - Implement exception handling to catch and display any potential exceptions related to database operations.

Notes:
- you are free to design the Console menu in any way.

```
---


# END