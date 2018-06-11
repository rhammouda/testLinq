using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        TestLinq.NorthwindEntities context = new TestLinq.NorthwindEntities();

        //1. Give the name, address, city, and region of employees
        [TestMethod]
        public void TestMethod1()
        {
        }

        //2. Give the name, address, city, and region of employees living in USA
        [TestMethod]
        public void TestMethod2()
        {
        }

        //3. Give the name, address, city, and region of employees older than 50 years old
        [TestMethod]
        public void TestMethod3()
        {
        }

        //4. Give the name, address, city, and region of employees that have placed orders to be
        //delivered in Belgium.Write two versions of the query, with and without join
        [TestMethod]
        public void TestMethod4()
        {
        }

        //5. Give the employee name and the customer name for orders that are sent by the
        //company ‘Speedy Express’ to customers who live in Brussels.
        [TestMethod]
        public void TestMethod5()
        {
        }

        //6. Give the title and name of employees who have sold at least one of the products
        //‘Gravad Lax’ or ‘Mishi Kobe Niku’.
        [TestMethod]
        public void TestMethod6()
        {
        }

        //7. Give the name and title of employees and the name and title of the person to which
        //they refer(or null for the latter values if they don’t refer to another employee).
        [TestMethod]
        public void TestMethod7()
        {
        }

        //8. Give the customer name, the product name and the supplier name for customers
        //who live in London and suppliers whose name is ‘Pavlova, Ltd.’ or ‘Karkki Oy’.
        [TestMethod]
        public void TestMethod8()
        {
        }

        //9. Give the name of products that were bought or sold by people who live in London.
        //Write two versions of the query, with and without union.
        [TestMethod]
        public void TestMethod9()
        {
        }

        //10. Give the names of employees who are strictly older than:
        //(a) an employee who lives in London.
        [TestMethod]
        public void TestMethod10a()
        {
        }

        //(b) any employee who lives in London.
        [TestMethod]
        public void TestMethod10b()
        {
        }

        //11. Give the name of employees who work longer than any employee of London.
        [TestMethod]
        public void TestMethod11()
        {
        }

        //12. Give the name of employees and the city where they live for employees who have
        //sold to customers in the same city.
        [TestMethod]
        public void TestMethod12()
        {
        }

        //13. Give the name of customers who have not purchased any product.
        [TestMethod]
        public void TestMethod13()
        {
        }

        //14. Give the name of customers who bought all products with price less than 5.
        [TestMethod]
        public void TestMethod14()
        {
        }

        //15. Give the name of the products sold by all employees.
        [TestMethod]
        public void TestMethod15()
        {
        }
        //16. Give the name of customers who bought all products purchased by the customer
        //whose identifier is ‘LAZYK’
        [TestMethod]
        public void TestMethod16()
        {
        }
        //17. Give the name of customers who bought exactly the same products as the customer
        //whose identifier is ‘LAZYK’
        [TestMethod]
        public void TestMethod17()
        {
        }
        //18. Give the average price of products by category.
        [TestMethod]
        public void TestMethod18()
        {
        }
        //19. Given the name of the categories and the average price of products in each category.
        [TestMethod]
        public void TestMethod19()
        {
        }
        //20. Give the identifier and the name of the companies that provide more than 3 products.
        [TestMethod]
        public void TestMethod20()
        {

        }
        //21. Give the identifier, name, and number of orders of employees, ordered by the employee
        //identifier.
        [TestMethod]
        public void TestMethod21()
        {

        }
        //22. For each employee give the identifier, name, and the number of distinct products
        //sold, ordered by the employee identifier.
        [TestMethod]
        public void TestMethod22()
        {

        }
        //23. Give the identifier, name, and total sales of employees, ordered by the employee
        //identifier.
        [TestMethod]
        public void TestMethod23()
        {

        }
        //24. Give the identifier, name, and total sales of employees, ordered by the employee
        //identifier for employees who have sold more than 70 different products.
        [TestMethod]
        public void TestMethod24()
        {

        }
        //25. Give the names of employees who sell the products of more than 7 suppliers.
        [TestMethod]
        public void TestMethod25()
        {

        }
        //26. Give the customer name and the product name such that the quantity of this product
        //bought by the customer in a single order is more than 5 times the average quantity
        //of this product bought in a single order among all clients.
        [TestMethod]
        public void TestMethod26()
        {

        }
    }
}
