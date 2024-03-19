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
---

# Today

## Topics
- LINQ to SQL

---
# RECAP: Provisioning Database

- We will use the Northwind database from Microsoft for this week.

- Know how to provision a database from a given SQL Script is vital

---

# DEMO - Setup LINQ to SQL Designer

---

# DEMO - Using LINQ to enhance you in-code queries

ref: https://mycanvas.mohawkcollege.ca/courses/92925/files/16713052?module_item_id=4763095

--- 

# DEMO - IEnumerable vs IQueryable

---

# Exercise

```
1. Setup:
   - Create a new Console Application
   - Create a LINQ to SQL data context for the Northwind database.

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