﻿using RestaurantSystem.Data.Models;
using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Controllers
{
    public static class FormToDBController
    {
        public static ICollection<Product> LoadProductsFromDataBase(ref DBController controller)
        {
            return controller.LoadProducts();
        }

        public static void AddProductInDataBase(ref DBController controller, string prName, int quantity, double prPrice, double dlPrice)
        {
            controller.AddProduct(prName, quantity, prPrice, dlPrice);
        }

        public static void EditProductInDataBase(ref DBController controller, string prName, int quantity, double prPrice, double dlPrice)
        {
            controller.EditProduct(prName, quantity, prPrice, dlPrice);
        }

        public static Product SelectProductById(ref DBController controller, int id)
        {
            return controller.SelectProductById(id);
        }

        public static List<Employee> SelectEmployees(ref DBController controller)
        {
            return controller.GetEmployers();
        }

        public static String GetEmployerJobPosition(ref DBController controller, string firstName, string lastName)
        {
            return controller.GetEmployerJobPosition(firstName, lastName);
        }

        public static String GetEmployerUserName(ref DBController controller, string firstName, string lastName)
        {
            return controller.GetEmployerUserName(firstName, lastName);
        }

        public static String GetEmployerPassword(ref DBController controller, string firstName, string lastName)
        {
            return controller.GetEmployerPassword(firstName, lastName);
        }

        public static void AddUserToDataBase(ref DBController controller, string username, string role, string password, string firstName, string lastName)
        {
            controller.AddUserToDataBase(username, password, role, firstName, lastName);
        }

        public static ICollection<Dish> LoadDishesFromDataBase(ref DBController controller)
        {
            return controller.LoadDishes();
        }

        public static void AddDishesToDataBase(ref DBController controller, string dName, double dPrice, double dWeight, ICollection<int> productsInDish, string productsQuantities)
        {
            controller.AddDish(dName, dPrice, dWeight, productsInDish, productsQuantities);
        }

        public static void EditDishInDataBase(ref DBController controller, string dName, double dPrice, double dWeight, ICollection<Product> productsInDish, string productsQuantities)
        {
            controller.EditDish(dName, dPrice, dWeight, productsInDish, productsQuantities);
        }

        public static Product SelectProductByNameFromDataBase(ref DBController controller, string productName)
        {
            return controller.SelectProductByName(productName);
        }

        public static bool AddElectricityExpenseInDataBaseIfNotExists(ref DBController controller, string dateString, double eValue)
        {
            return controller.AddElectricityExpense(dateString, eValue);
        }

        public static bool AddWaterExpenseInDataBaseIfNotExists(ref DBController controller, string dateString, double wValue)
        {
            return controller.AddWaterExpense(dateString, wValue);
        }

        public static bool AddInternetExpenseInDataBaseIfNotExists(ref DBController controller, string dateString, double iValue)
        {
            return controller.AddInternetExpense(dateString, iValue);
        }

        public static bool EditExpensesInDataBase(ref DBController controller, string dateString, double eValue, double wValue, double iValue)
        {
            return controller.EditExpenses(dateString, eValue, wValue, iValue);
        }

        public static List<Expenses> GetExpensesFromDataBase(ref DBController controller, string dateString)
        {
            return controller.GetExpenses(dateString);
        }

        public static double GetDayReportExpensesFromDataBase(ref DBController controller, string dateString)
        {
            return controller.GetDayReportExpenses(dateString);
        }

        public static double GetDayReportIncomesFromDataBase(ref DBController controller, string dateString)
        {
            return controller.GetDayReportIncomes(dateString);
        }

        public static List<DishProducts> SelectAllDishProducts(ref DBController controller, int id)
        {
            return controller.SelectAllDishProducts(id);
        }

        public static Dish SelectDishById(ref DBController controller, int id)
        {
            return controller.SelectDishById(id);
        }

        public static ICollection<Supplier> LoadSuppliersFromDataBase(ref DBController controller)
        {
            return controller.LoadSuppliers();
        }

        public static void AddSupplierInDataBase(ref DBController controller, string supplierName, string supplierPhone, string supplierAvailableDays)
        {
            controller.AddSupplier(supplierName, supplierPhone, supplierAvailableDays);
        }

        public static void EditSupplierInDataBase(ref DBController controller, string supplierName, string supplierPhone, string supplierAvailableDays)
        {
            controller.EditSupplier(supplierName, supplierPhone, supplierAvailableDays);
        }

        public static ICollection<Delivery> LoadDeliveriesFromDataBase(ref DBController controller)
        {
            return controller.LoadDeliveries();
        }

        public static ICollection<Product> GetDeliveryProductsFromDataBase(ref DBController controller,int id)
        {
            return controller.GetDeliveryProducts(id);
        }

        public static void AddDeliveryInDataBase(ref DBController controller, string productName, int productQuantity, string supplierName)
        {
            controller.AddDelivery(productName, productQuantity, supplierName);
        }

        public static void ApproveDeliveryInDataBase(ref DBController controller,string supplierName)
        {
            controller.ApproveDelivery(supplierName);
        }



    }
}
