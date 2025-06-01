using System;
using System.Collections.Generic;
using System.Linq;
using Projekt_Restauracja.Models;

public static class TestDataGenerator
{
    public static void PopulateReservations()
    {
        var random = new Random();

        var firstNames = new[] { "Jan", "Anna", "Piotr", "Kasia", "Marek", "Agnieszka", "Tomasz", "Ewa" };
        var lastNames = new[] { "Kowalski", "Nowak", "Wiśniewski", "Wójcik", "Krawczyk", "Kamińska" };
        var phonePrefixes = new[] { "601", "602", "503", "511", "721" };
        var times = new[] { "12:00", "12:45", "13:30", "14:15", "15:00", "15:45", "16:30", "17:15", "18:00", "18:45", "19:30", "20:15", "21:00" };

        using (var context = new RestaurantContext())
        {
            var menuItems = context.MenuItems.ToList();
            if (!menuItems.Any())
            {
                MessageBox.Show("Brak pozycji w menu. Dodaj najpierw menu.");
                return;
            }

            for (int d = -30; d <= 30; d++)
            {
                var day = DateTime.Today.AddDays(d);
                foreach (var time in times)
                {
                    for (int tableNumber = 1; tableNumber <= 6; tableNumber++)
                    {
                        if (random.NextDouble() < 0.15) continue;

                        var name = $"{firstNames[random.Next(firstNames.Length)]} {lastNames[random.Next(lastNames.Length)]}";
                        var phone = phonePrefixes[random.Next(phonePrefixes.Length)] +
                                    random.Next(100000, 999999).ToString();
                        var reservationNumber = random.Next(100000, 999999).ToString();

                        var customer = context.Customers.FirstOrDefault(c => c.Name == name && c.PhoneNumber == phone);
                        if (customer == null)
                        {
                            customer = new Customer { Name = name, PhoneNumber = phone };
                            context.Customers.Add(customer);
                            context.SaveChanges();
                        }

                        bool exists = context.Reservations.Any(r =>
                            r.ReservationDate == day &&
                            r.ReservationTime == time &&
                            r.TableNumber == tableNumber);

                        if (exists) continue;

                        var reservation = new Reservation
                        {
                            CustomerId = customer.CustomerId,
                            CustomerName = name,
                            PhoneNumber = phone,
                            ReservationDate = day,
                            ReservationTime = time,
                            TableNumber = tableNumber,
                            TotalAmount = 0,
                            ReservationNumber = reservationNumber
                        };
                        context.Reservations.Add(reservation);
                        context.SaveChanges();

                        var order = new Order
                        {
                            ReservationId = reservation.Id,
                            OrderItems = new List<OrderItem>(),
                            CreatedAt = DateTime.Now,
                            OrderDate = day
                        };

                        int numItems = random.Next(1, 4);
                        decimal total = 0;
                        var usedIndexes = new HashSet<int>();
                        for (int j = 0; j < numItems; j++)
                        {
                            int itemIdx;
                            do
                            {
                                itemIdx = random.Next(menuItems.Count);
                            } while (!usedIndexes.Add(itemIdx));
                            var menuItem = menuItems[itemIdx];

                            int qty = random.Next(1, 5);
                            total += menuItem.Price * qty;

                            var orderItem = new OrderItem
                            {
                                MenuItemId = menuItem.MenuItemId,
                                Quantity = qty,
                                UnitPrice = menuItem.Price
                            };
                            order.OrderItems.Add(orderItem);
                        }

                        order.TotalAmount = order.OrderItems.Sum(oi => oi.UnitPrice * oi.Quantity);
                        reservation.TotalAmount = order.TotalAmount;

                        context.Orders.Add(order);
                        context.SaveChanges();
                    }
                }
            }
        }
        MessageBox.Show("Baza danych została uzupełniona przykładowymi rezerwacjami!");
    }
}