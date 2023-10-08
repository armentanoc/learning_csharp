using System;
using System.Collections.Generic;

namespace Fundamentals
    {
        public class SalesManagement
        {
            public void run()
            {
                List<Product> products = generateProducts();
                bool continueShopping = true;

                while (continueShopping)
                {
                    printProducts(products);
                    products = buyProduct(products);

                    Console.WriteLine("Deseja comprar outro produto? (S/N)");
                    string userInput = Console.ReadLine().Trim();

                    // Check if the user wants to continue shopping
                    if (!userInput.Equals("S", StringComparison.OrdinalIgnoreCase))
                    {
                        continueShopping = false;
                    }
                }

                printProductsWithTotal(products);
            }

            private List<Product> buyProduct(List<Product> products)
            {
                Console.WriteLine("Qual o código do produto que deseja comprar?");
                if (int.TryParse(Console.ReadLine(), out int code))
                {
                    bool productFound = false;

                    foreach (Product product in products)
                    {
                        if (code == product.getCode())
                        {
                            Console.WriteLine("Qual a quantidade que deseja comprar?");
                            if (int.TryParse(Console.ReadLine(), out int qtd) && qtd > 0)
                            {
                                product.setTotal(product.getValue() * qtd);
                                product.setQtd(qtd);
                            }
                            else if (qtd <= 0)
                            {
                                Console.WriteLine("A quantidade precisa ser maior que zero.");
                            }

                            productFound = true;
                            break;
                        }
                    }

                    if (!productFound)
                    {
                        Console.WriteLine("Produto com código informado não encontrado.");
                    }
                }
                else
                {
                    Console.WriteLine("Código inválido. Certifique-se de inserir um número inteiro.");
                }

                return products;
            }

            public class Product

            {

                private int code;
                private string name;
                private double value;
                private double total = 0;
                private int qtd = 0;

                public Product(int code, string name, double value)
                {
                    this.code = code;
                    this.name = name;
                    this.value = value;
                }

                public string getName()
                {
                    return name;
                }

                public int getCode()
                {
                    return code;
                }

                public void setTotal(double value)
                {
                    this.total += value;
                }
                public double getTotal()
                {
                    return total;
                }

                public double getValue()
                {
                    return value;
                }

                public void setQtd(int qtd)
                {
                    this.qtd += qtd;
                }
                public int getQtd()
                {
                    return qtd;
                }
            }

            public List<Product> generateProducts()
            {
                List<Product> products = new List<Product>();
                Product product;
                product = new Product(1, "Arroz", 4.50);
                products.Add(product);
                product = new Product(2, "Feijão", 7.50);
                products.Add(product);
                product = new Product(3, "Macarrão", 2.50);
                products.Add(product);
                product = new Product(4, "Farinha", 3.50);
                products.Add(product);
                return products;

            }

            public void printProducts(List<Product> products)
            {
                Console.WriteLine("\nLISTA DE PRODUTOS:\n");

                foreach (var product in products)
                {
                    Console.WriteLine(" (" + product.getCode() + ") " + product.getName() + " => " + product.getValue().ToString("C"));
                }
                Console.WriteLine();

            }

            public void printProductsWithTotal(List<Product> products)
            {
                double totalCost = 0;
                Console.WriteLine("\nLISTA DE PRODUTOS:\n");

                foreach (var product in products)
                {
                    if (product.getTotal() > 0)
                    {
                        Console.WriteLine(product.getName() + " (Qtd: " + product.getQtd() + " e Valor Unitário: " + product.getValue().ToString("C") + ") => Total: " + product.getTotal().ToString("C"));
                        totalCost += product.getTotal();
                    }
                }

                Console.WriteLine("\nCusto Total: " + totalCost.ToString("C"));
            }
        }
     }
            /*

            DESAFIO 07:

            Uma loja de produtos eletrônicos com vendas regulares opta por contratar uma equipe
            para a organização de um sistema de gerenciamento de vendas. Elabore um algoritmo que,
            a partir de dados fornecidos pelo usuário, calcule o valor da venda de um produto,
            exibindo uma saída em vídeo contendo o código do produto, o nome, a quantidade
            comprada, o valor unitário e o valor total.

             */