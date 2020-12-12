using RestaurantSystem.Data;
using RestaurantSystem.Data.Models;
using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Controllers
{
    public class Controller
    {
        RestaurantDbContext db;

        public void CreateDB()
        {
            db = new RestaurantDbContext();
            db.Database.CreateIfNotExists();
        }

        public void AddProduct(string name, int quantity, double price, double dlprice)
        {
            db.Products.Add(new Product
            {
                Name = name,
                Quantity = quantity,
                Price = price,
                DeliveryPrice = dlprice
            });

            db.SaveChanges();
        }

        public ICollection<Product> LoadProducts()
        {
            return db.Products
                .Select(p => p)
                .ToArray();
        }

        public void EditProduct(string name, int quantity, double price, double dlprice)
        {
            Product product = db.Products.SingleOrDefault(p => p.Name == name);
            if (product != null)
            {
                product.Name = name;
                product.Quantity = quantity;
                product.Price = price;
                product.DeliveryPrice = dlprice;

                db.SaveChanges();
            }
        }

        public Product SelectProductByName(string name)
        {
            Product product = db.Products.SingleOrDefault(p => p.Name == name);
            return product;
        }

        public void AddDish(string dName, double dPrice, double dWeight, ICollection<Product> productsInDish)
        {
            Dish dish = new Dish
            {
                DishName = dName,
                DishPrice = dPrice,
                DishWeight = dWeight,
                Products = productsInDish
            };

            db.Dishes.Add(dish);

            foreach (Product product in productsInDish)
            {
                product.Dishes.Add(dish);
            }

            db.SaveChanges();
        }

        public Dish SelectDishByName(string name)
        {
            Dish dish = db.Dishes.SingleOrDefault(d => d.DishName == name);
            return dish;
        }

        public ICollection<Dish> LoadDishes()
        {
            return db.Dishes
                .Select(d => d)
                .ToArray();
        }

        public void EditDish(string dName, double dPrice, double dWeight, ICollection<Product> productsInDish)
        {
            Dish dish = db.Dishes.SingleOrDefault(d => d.DishName == dName);
            if (dish != null)
            {
                dish.DishPrice = dPrice;
                dish.DishWeight = dWeight;

                foreach (Product product in dish.Products)
                {
                    product.Dishes.Remove(dish);
                }

                dish.Products = null;

                db.SaveChanges();

                AddProductsToDish(dish, productsInDish);
            }
        }

        public void AddProductsToDish(Dish dish, ICollection<Product> productsInDish)
        {

            dish.Products = productsInDish;
            foreach (Product product in dish.Products)
            {
                product.Dishes.Add(dish);
            }

            db.SaveChanges();
        }

        public bool RemoveDish(string dName)
        {

            Dish dish = db.Dishes.SingleOrDefault(d => d.DishName == dName);
            if (dish != null)
            {
                db.Dishes.Remove(dish);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddDelivery()
        {
            ICollection<Product> products = LoadProducts();
            ICollection<Product> deliveryProducts = new HashSet<Product>();
            string name = null;
            int deliveryQuantity = 20;
            double deliveryPrice = 0;
            Supplier supplier = db.Suppliers.SingleOrDefault(s => s.Name == name);

            foreach (Product product in products)
            {
                if (product.Quantity != 0 && product.Name != null)
                {
                    deliveryProducts.Add(product);
                    deliveryPrice += product.DeliveryPrice;
                }
            }
            if (supplier.Name != null)
            {
                Delivery delivery = new Delivery
                {
                    DeliveryQuantity = deliveryQuantity,
                    DeliveryPrice = deliveryPrice * deliveryQuantity,
                    Supplier = supplier,
                    DeliveryDate = DateTime.UtcNow,
                    Approved = false,
                    Products = deliveryProducts
                };

                AddDeliveriesToSupplier(supplier, supplier.Deliveries);
            }
        }

        public Delivery SelectDeliveryByDeliveryQuantity(int quantity)
        {
            Delivery delivery = db.Deliveries.SingleOrDefault(d => d.DeliveryQuantity == quantity);
            return delivery;
        }

        public ICollection<Delivery> LoadDeliveries()
        {
            return db.Deliveries
                .Select(d => d)
                .ToArray();
        }

        public void EditDelivery(int dQuantity, ICollection<Product> deliveryProducts)
        {
            Delivery delivery = db.Deliveries.SingleOrDefault(d => d.DeliveryQuantity == dQuantity);

            if (delivery != null)
            {
                delivery.DeliveryQuantity = dQuantity;

                foreach (Product product in delivery.Products)
                {
                    delivery.Products.Remove(product);
                }

                delivery.Products = null;

                db.SaveChanges();
            };

        }

        public void AddDeliveriesToSupplier(Supplier supplier, ICollection<Delivery> deliveries)
        {
            supplier.Deliveries = deliveries;
            foreach (Delivery delivery in deliveries)
            {
                supplier.Deliveries.Add(delivery);
            }

            db.SaveChanges();
        }

        public void ApproveDelivery(int dQuantity, ICollection<Product> deliveryProducts)
        {
            Delivery delivery = db.Deliveries.SingleOrDefault(d => d.Products == deliveryProducts);

            if (delivery != null)
            {
                delivery.DeliveryQuantity = dQuantity;
                delivery.Approved = true;

                db.SaveChanges();
            };
        }

        public bool AddElectricityExpense(string dateString, double elValue)
        {
            DateTime expenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);

            Expenses checkExpense = db.Expenses.SingleOrDefault(ex => ex.Name == "Ток" && ex.ExpenseDate == expenseDate);

            if (checkExpense != null)
            {
                return false;
            }
            else
            {
                Expenses expense = new Expenses
                {
                    Name = "Ток",
                    Value = elValue,
                    ExpenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ",
                                System.Globalization.CultureInfo.InvariantCulture)
                };

                db.Expenses.Add(expense);
                db.SaveChanges();
                return true;
            }
        }

        public bool AddWaterExpense(string dateString, double wValue)
        {
            DateTime expenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);

            Expenses checkExpense = db.Expenses.SingleOrDefault(ex => ex.Name == "Вода" && ex.ExpenseDate == expenseDate);

            if (checkExpense != null)
            {
                return false;
            }
            else
            {
                Expenses expense = new Expenses
                {
                    Name = "Вода",
                    Value = wValue,
                    ExpenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ",
                                System.Globalization.CultureInfo.InvariantCulture)
                };

                db.Expenses.Add(expense);
                db.SaveChanges();
                return true;
            }
        }

        public bool AddInternetExpense(string dateString, double iValue)
        {
            DateTime expenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);

            Expenses checkExpense = db.Expenses.SingleOrDefault(ex => ex.Name == "Интернет" && ex.ExpenseDate == expenseDate);

            if (checkExpense != null)
            {
                return false;
            }
            else
            {
                Expenses expense = new Expenses
                {
                    Name = "Интернет",
                    Value = iValue,
                    ExpenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ",
                              System.Globalization.CultureInfo.InvariantCulture)
                };

                db.Expenses.Add(expense);
                db.SaveChanges();
                return true;
            }
        }

        public List<Expenses> GetExpenses(string dateString)
        {
            DateTime expenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);

            Expenses electricityExpense = db.Expenses.SingleOrDefault(e => e.ExpenseDate == expenseDate && e.Name == "Ток");
            Expenses waterExpense = db.Expenses.SingleOrDefault(e => e.ExpenseDate == expenseDate && e.Name == "Вода");
            Expenses internetExpense = db.Expenses.SingleOrDefault(e => e.ExpenseDate == expenseDate && e.Name == "Интернет");

            List<Expenses> expenses = new List<Expenses>()
            {
                electricityExpense,
                waterExpense,
                internetExpense
            };

            List<int> indexesToRemove = new List<int>();

            foreach(Expenses expense in expenses)
            {
                if(expense == null)
                {
                    indexesToRemove.Add(expenses.IndexOf(expense));
                }
            }

            foreach(int index in indexesToRemove)
            {
                expenses.RemoveAt(index);
            }

            return expenses;
        }

        public bool EditExpenses(string dateString, double eValue, double wValue, double iValue)
        {
            DateTime expenseDate = DateTime.ParseExact(dateString, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);

            List<Expenses> expenses = db.Expenses.Where(ex => ex.ExpenseDate == expenseDate).ToList();

            bool check = false;

            while(expenses.Count < 3)
            {
                expenses.Add(new Expenses
                {
                    Name = "невалиден"
                });
            }

            foreach(Expenses expense in expenses)
            {
                if (expense.Name == "Ток" && eValue != 0)
                {
                    expense.Value = eValue;
                    check = true;
                }
                else if (expense.Name == "Ток" && eValue == 0)
                {
                    continue;
                }
                else if (expense.Name == "Вода" && wValue != 0)
                {
                    expense.Value = wValue;
                    check = true;
                }
                else if(expense.Name == "Вода" && wValue == 0)
                {
                    continue;
                }
                else if (expense.Name == "Интернет" && iValue != 0)
                {
                    expense.Value = iValue;
                    check = true;
                }
                else if (expense.Name == "Интернет" && iValue == 0)
                {
                    continue;
                }
                else if(expense.Name == "невалиден" && check == true)
                {
                    break;
                }
                else
                {
                    return false;
                }
            }
            db.SaveChanges();
            return true;
        }
    }
}
