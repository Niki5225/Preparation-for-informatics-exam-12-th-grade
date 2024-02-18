namespace Task
{
    class Task
    {
        static void Main()
        {
            
            string command = Console.ReadLine();
            double money = 0;

            while (command != "Start")
            {
                double coin = double.Parse(command);

                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    money += coin;
                } else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }


                command = Console.ReadLine();
            }

            string newCommand = Console.ReadLine();

            while (newCommand != "End")
            {
                string product = newCommand;

                if (validateProduct(product))
                {
                    if (checkIfProductCouldBeBought(product))
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    } else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    
                } else
                {
                    Console.WriteLine("Invalid product");
                }

                newCommand = Console.ReadLine();
            }

            Console.WriteLine($"Change: {money:F2}");

            bool checkIfProductCouldBeBought(string product)
            {
                if (product == "Nuts")
                {
                    if (money >= 2.0)
                    {
                        money -= 2.0;
                        return true;
                    } else
                    {
                        return false;
                    }
                } else if (product == "Water")
                {
                    if (money >= 0.7)
                    {
                        money -= 0.7;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                } else if (product == "Crisps")
                {
                    if (money >= 1.5)
                    {
                        money -= 1.5;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                } else if (product == "Soda")
                {
                    if (money >= 0.8)
                    {
                        money -= 0.8;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                } else
                {
                    if (money >= 1.0)
                    {
                        money -= 1.0;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        static bool validateProduct(string product)
        {
            if (product == "Nuts" || product == "Coke" || product == "Crisps" || product == "Water" || product == "Soda")
            {
                return true;
            } else
            {
                return false;
            }
        }

        
    }
}